using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    [Header("Set In Inspector")]
    public List<GameObject> medicines; // Get the list of medicines in the editor
    public List<GameObject> npcsList; // Get the list of npcs in the editor
    public List<GameObject> rpgTalkInstances; // Get the list of RPGTalk Holders to determine the dialogue played
    public AudioSource medicineSoundSource;

    public AudioClip[] medicineNamesSound;
    //Sound Name Library:
    //[0]Acetaminophen
    //[1]Acyclovir
    //[2]Albuterol
    //[3]Alfuzosin
    //[4]Amoxicillin
    //[5]Benazepril
    //[6]Caspofungin
    //[7]Dexamethasone
    //[8]Epinephrine
    //[9]Etonogestrel
    //[10]Heparin
    //[11]Ibuprofen
    //[12]Loratadine
    //[13]Lorazepam
    //[14]Metoprolol
    //[15]Omeprazole
    //[16]Ondansetron
    //[17]Sildenafil
    //[18]Sumatriptan
    //[19]Trazodone
    //[20]Metformin
    //[21]Lovastatin

    // We want to get the transforms of the ten medicine in the medicine cabinet
    Vector3 pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9, pos10;

    // We want to move the character to different positions for each NPC scene
    Vector3 trans1, trans2, trans3, trans4, trans5, trans6, trans7, trans8, trans9, trans10;

    // We want a list of the npcs to make sure the correct medicine is in the medicine cabinet when it is randomized
    string[] npcs = { "NPC Mia", "NPC Laura", "NPC Kelly", "NPC Sarah", "NPC Jake", "NPC Connor", "NPC Ryan", "NPC Eden", "NPC Luna", "NPC Jamie" };

    public static bool pushToTalkOn = true;
    public static string currentNPC = "";
    public static string patientNum = "";

    // We want to randomize each medicine
    private List<GameObject> randomizedMedicines;
    GameObject myGameObject;
    System.Random random = new System.Random();

    // Initialize variables or game states before the game starts (only called once)
    void Awake()
    {
        // Row 1
        pos1 = new Vector3(69.5f, -63.0f, 0.0f);
        pos2 = new Vector3(249.5f, -63.0f, 0.0f);
        pos3 = new Vector3(429.5f, -63.0f, 0.0f);

        // Row 2
        pos4 = new Vector3(159.5f, -185.0f, 0.0f);
        pos5 = new Vector3(339.5f, -185.0f, 0.0f);

        // Row 3
        pos6 = new Vector3(69.5f, -305.0f, 0.0f);
        pos7 = new Vector3(249.5f, -305.0f, 0.0f);
        pos8 = new Vector3(429.5f, -305.0f, 0.0f);

        // Row 4
        pos9 = new Vector3(159.5f, -424.8f, 0.0f);
        pos10 = new Vector3(339.5f, -424.8f, 0.0f);

        // Character Positions
        trans1 = new Vector3(10.0f, -3.2f, 0.0f); // Mia
        trans2 = new Vector3(9.7f, 2.8f, 0.0f); // Laura
        trans3 = new Vector3(6.6f, -3.2f, 0.0f); // Kelly
        trans4 = new Vector3(12.8f, 2.6f, 0.0f); // Sarah
        trans5 = new Vector3(-10.5f, 2.3f, 0.0f); // Jake
        trans6 = new Vector3(-5.5f, 2.3f, 0.0f); // Connor
        trans7 = new Vector3(-11.0f, -3.7f, 0.0f); // Ryan
        trans8 = new Vector3(-4.5f, -3.9f, 0.0f); // Eden
        trans9 = new Vector3(-13.5f, 2.3f, 0.0f); // Luna
        trans10 = new Vector3(-1.5f, 0.1f, 0.0f); // Jamie
    }

    // Start is called before the first frame update
    void Start()
    {
        ChooseNPC(); // Choose NPC for the level
        ShuffleElements(); // Randomize list of medicines
        Validate(); // Make sure the medicine we need to complete the level is present
        SetTransform(); // Set the transform of the first ten medicines in the randomized list
        SetActive(); // Set the game objects of the first ten medicines active in the editor

        // print(TotalScore.totalStars);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void ChooseNPC()
    {
        int index;
        int n = npcsList.Count;
        string npcName;
        var list = new List<string>(DetermineNPC.presentNPCS);
        int length = DetermineNPC.presentNPCS.Length;

        // print("Length of array: " + length);

        index = UnityEngine.Random.Range(0, length); // Get random number for index in array

        // print("Get NPC at index: " + index);

        npcName = DetermineNPC.presentNPCS[index]; // Get the npc in the index of the array

        for (int i = 0; i < n; i++)
        {
            if (npcsList[i].name == npcName)
            {
                // print("NPC Set Active: " + npcsList[i]);
                npcsList[i].SetActive(true);
                break;
            }
        }

        list.Remove(npcName); // Remove the npc from the list
        DetermineNPC.presentNPCS = list.ToArray(); // Update the array with the list

        // print("Deleting NPC... New length of array: " + DetermineNPC.presentNPCS.Length);
    }

    private void ShuffleElements()
    {
        randomizedMedicines = new List<GameObject>(medicines);
        int n = medicines.Count;

        // Randomly sort the list of medicines using the Fisher-Yates shuffle
        for (int i = 0; i < n; i++)
        {
            int r = i + (int)(random.NextDouble() * (n - i));
            myGameObject = randomizedMedicines[r];
            randomizedMedicines[r] = randomizedMedicines[i];
            randomizedMedicines[i] = myGameObject;
        }

        // Remove the medicine starting from the 10th index to the last (we only want the first ten medicines)
        randomizedMedicines.RemoveRange(10, 10);
    }

    private void Validate()
    {
        int n = npcs.Length;
        int count = 0;
        int reshuffle = 0;
        string npc = "";
        string correctMedicine = "";
        string partiallyCorrectMedicine = "";
        GameObject dialogueOption;
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        for (int i = 0; i < n; i++)
        {
            // Search through the list of NPC's and find out which one is present
            // && GameObject.Find(npcs[i]).activeSelf == true)
            if (GameObject.Find(npcs[i]) != null)
            {
                npc = GameObject.Find(npcs[i]).name;
                // print("Looped " + count + " times. " + npcs[i] + " has been found! Break!");
                break;
            }

            ++count;
        }

        // Change the correct medicine based on the NPC that spawns
        switch (npc)
        {
            case "NPC Mia":
                dialogueOption = rpgTalkInstances.Find((x) => x.name == "RPGTalk Holder 1");
                GameManager.currentNPC = "NPC Mia";
                GameManager.patientNum = "1";
                DialogueAndMovement.rpgTalk = dialogueOption.GetComponent<RPGTalk>();
                FadeBetweenLevel.RPGTalkBegin = dialogueOption;
                player.transform.position = trans1;
                correctMedicine = "Trazodone Slot";
                partiallyCorrectMedicine = "";
                // print("Mia's story is now playing!");
                break;
            case "NPC Laura":
                dialogueOption = rpgTalkInstances.Find((x) => x.name == "RPGTalk Holder 2");
                GameManager.currentNPC = "NPC Laura";
                GameManager.patientNum = "2";
                DialogueAndMovement.rpgTalk = dialogueOption.GetComponent<RPGTalk>();
                FadeBetweenLevel.RPGTalkBegin = dialogueOption;
                player.transform.position = trans2;
                correctMedicine = "Acetaminophen Slot";
                partiallyCorrectMedicine = "Ibuprofen Slot";
                // print("Laura's story is now playing!");
                break;
            case "NPC Kelly":
                dialogueOption = rpgTalkInstances.Find((x) => x.name == "RPGTalk Holder 3");
                GameManager.currentNPC = "NPC Kelly";
                GameManager.patientNum = "3";
                DialogueAndMovement.rpgTalk = dialogueOption.GetComponent<RPGTalk>();
                FadeBetweenLevel.RPGTalkBegin = dialogueOption;
                player.transform.position = trans3;
                correctMedicine = "Etonogestrel Slot";
                partiallyCorrectMedicine = "";
                // print("Kelly's story is now playing!");
                break;
            case "NPC Sarah":
                dialogueOption = rpgTalkInstances.Find((x) => x.name == "RPGTalk Holder 4");
                GameManager.currentNPC = "NPC Sarah";
                GameManager.patientNum = "4";
                DialogueAndMovement.rpgTalk = dialogueOption.GetComponent<RPGTalk>();
                FadeBetweenLevel.RPGTalkBegin = dialogueOption;
                player.transform.position = trans4;
                correctMedicine = "Loratadine Slot";
                partiallyCorrectMedicine = "";
                // print("Sarah's story is now playing!");
                break;
            case "NPC Jake":
                dialogueOption = rpgTalkInstances.Find((x) => x.name == "RPGTalk Holder 5");
                GameManager.currentNPC = "NPC Jake";
                GameManager.patientNum = "5";
                DialogueAndMovement.rpgTalk = dialogueOption.GetComponent<RPGTalk>();
                FadeBetweenLevel.RPGTalkBegin = dialogueOption;
                player.transform.position = trans5;
                correctMedicine = "Sumatriptan Slot";
                partiallyCorrectMedicine = "";
                // print("Jake's story is now playing!");
                break;
            case "NPC Connor":
                dialogueOption = rpgTalkInstances.Find((x) => x.name == "RPGTalk Holder 6");
                GameManager.currentNPC = "NPC Connor";
                GameManager.patientNum = "6";
                DialogueAndMovement.rpgTalk = dialogueOption.GetComponent<RPGTalk>();
                FadeBetweenLevel.RPGTalkBegin = dialogueOption;
                player.transform.position = trans6;
                correctMedicine = "Metoprolol Slot";
                partiallyCorrectMedicine = "Ibuprofen Slot";
                // print("Connor's story is now playing!");
                break;
            case "NPC Ryan":
                dialogueOption = rpgTalkInstances.Find((x) => x.name == "RPGTalk Holder 7");
                GameManager.currentNPC = "NPC Ryan";
                GameManager.patientNum = "7";
                DialogueAndMovement.rpgTalk = dialogueOption.GetComponent<RPGTalk>();
                FadeBetweenLevel.RPGTalkBegin = dialogueOption;
                player.transform.position = trans7;
                correctMedicine = "Albuterol Slot";
                partiallyCorrectMedicine = "";
                // print("Ryan's story is now playing!");
                break;
            case "NPC Eden":
                dialogueOption = rpgTalkInstances.Find((x) => x.name == "RPGTalk Holder 8");
                GameManager.currentNPC = "NPC Eden";
                GameManager.patientNum = "8";
                DialogueAndMovement.rpgTalk = dialogueOption.GetComponent<RPGTalk>();
                FadeBetweenLevel.RPGTalkBegin = dialogueOption;
                player.transform.position = trans8;
                correctMedicine = "Acyclovir Slot";
                partiallyCorrectMedicine = "";
                // print("Eden's story is now playing!");
                break;
            case "NPC Luna":
                dialogueOption = rpgTalkInstances.Find((x) => x.name == "RPGTalk Holder 9");
                GameManager.currentNPC = "NPC Luna";
                GameManager.patientNum = "9";
                DialogueAndMovement.rpgTalk = dialogueOption.GetComponent<RPGTalk>();
                FadeBetweenLevel.RPGTalkBegin = dialogueOption;
                player.transform.position = trans9;
                correctMedicine = "Lovastatin Slot";
                partiallyCorrectMedicine = "";
                // print("Luna's story is now playing!");
                break;
            case "NPC Jamie":
                dialogueOption = rpgTalkInstances.Find((x) => x.name == "RPGTalk Holder 10");
                GameManager.currentNPC = "NPC Jamie";
                GameManager.patientNum = "10";
                DialogueAndMovement.rpgTalk = dialogueOption.GetComponent<RPGTalk>();
                FadeBetweenLevel.RPGTalkBegin = dialogueOption;
                player.transform.position = trans10;
                correctMedicine = "Omeprazole Slot";
                partiallyCorrectMedicine = "";
                // print("Jamie's story is now playing!");
                break;
            default:
                correctMedicine = "";
                partiallyCorrectMedicine = "";
                // print("Oh no! It looks like something bad happened!");
                break;
        }

        // Now we want to check if the correct medicine is present in the randomized list of medicines
        GameObject findMedicine = randomizedMedicines.Find((med) => med.name == correctMedicine);
        // print("FindMedicine Variable: " + findMedicine);

        // Check if there was a middle option
        GameObject findPartialMedicine = randomizedMedicines.Find((pMed) => pMed.name == partiallyCorrectMedicine);
        // print("FindPartialMedicine Variable: " + findPartialMedicine);

        // If it is not present, then we want to reshuffle until it is present
        while (findMedicine == null || (findMedicine != null && (findMedicine.name == "Acetaminophen Slot" || findMedicine.name == "Metoprolol Slot") && findPartialMedicine == null))
        {
            ShuffleElements();
            findMedicine = randomizedMedicines.Find((med) => med.name == correctMedicine);
            findPartialMedicine = randomizedMedicines.Find((pMed) => pMed.name == partiallyCorrectMedicine);
            reshuffle++;
            /*            
                        if (findMedicine == null)
                        {
                            print("Medicine not found! Reshuffling...");
                        }
                        if (findMedicine != null)
                        {
                            print("Medicine found:" + findMedicine);
                        }
                        if (findMedicine != null && (findMedicine.name == "Acetaminophen Slot" || findMedicine.name == "Metoprolol Slot") && findPartialMedicine == null)
                        {
                            print("Partial medicine not found! Reshuffling... ");
                        }
                        if (findMedicine != null && (findMedicine.name == "Acetaminophen Slot" || findMedicine.name == "Metoprolol Slot") && findPartialMedicine != null)
                        {
                            print("Partial medicine found: " + partiallyCorrectMedicine);
                            print("Shuffing has ended.");
                        }
            */
        }

        // print("Reshuffled " + reshuffle + " times.");
        // print("Correct Medicine: " + findMedicine);
        if (findPartialMedicine != null)
        {
            // print("Partially Correct Medicine: " + findPartialMedicine);
        }
        // print("-------------------------------------------------------------------------------------------------------------------");
    }

    private void SetTransform()
    {
        // Use transform.localPosition because the medicines are children on another Game Object
        randomizedMedicines[0].transform.localPosition += pos1;
        randomizedMedicines[1].transform.localPosition += pos2;
        randomizedMedicines[2].transform.localPosition += pos3;
        randomizedMedicines[3].transform.localPosition += pos4;
        randomizedMedicines[4].transform.localPosition += pos5;
        randomizedMedicines[5].transform.localPosition += pos6;
        randomizedMedicines[6].transform.localPosition += pos7;
        randomizedMedicines[7].transform.localPosition += pos8;
        randomizedMedicines[8].transform.localPosition += pos9;
        randomizedMedicines[9].transform.localPosition += pos10;
    }

    private void SetActive()
    {
        for (int i = 0; i < 10; i++)
        {
            randomizedMedicines[i].SetActive(true);
        }
    }

    public void PlayMedNameSoundEffect(int index)
    {
        if (pushToTalkOn)
        {
            medicineSoundSource.clip = medicineNamesSound[index];
            medicineSoundSource.Play();
        }

    }
}
