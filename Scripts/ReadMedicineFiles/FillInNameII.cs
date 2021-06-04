using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;


public class FillInNameII : MonoBehaviour
{
    string[] descriptionArray;

    //Variables to store info from complete meds file 
    string[] allMeds;
    string[] subArrayMedsInfo;
    public TextAsset completeFile;


    public Transform medsInfoStorage;

    void Awake()
    {

        ReadFromCompleteFile();

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    //Reads the text file with all medicines and info and stores them in subArrayMedsInfo
    public void ReadFromCompleteFile()
    {
        allMeds = completeFile.text.Split("="[0]);    //ds - first split on each med sep by ==

        string medName;
        string description2;

        for (int i = 0; i < allMeds.Length; i++)
        {
            subArrayMedsInfo = allMeds[i].Split("\n"[0]);  //ds - then each med by line
           //readName = SetStringDescription1(subArrayMedsInfo);
            //description2 = SetStringDescription2(subArrayMedsInfo);
            setMedName(subArrayMedsInfo[0]);

        }

    }

    public void setMedName(string medName) //before: string medName, string description
    {
        string medInfo = medName;
        Transform medObject = medsInfoStorage.transform.Find(medInfo);


        //Transform goDescription = medObject.transform.Find("Description 1");
        //Transform itemFrame = goDescription.transform.Find("Item Frame");
  


        TextMeshProUGUI text1 = medObject.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>();
        text1.SetText(medName);
        


    }

}
