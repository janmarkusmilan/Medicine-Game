using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TutorialSetTalk : MonoBehaviour
{
    [Header("Set In Inspector")]
    public List<GameObject> rpgTalkInstances; // Get the list of RPGTalk Holders to determine the dialogue played

    GameObject dialogueOption;

    // Use this for initialization
    void Start()
    {
        dialogueOption = rpgTalkInstances.Find((x) => x.name == "RPGTalk Holder");
        DialogueAndMovement.rpgTalk = dialogueOption.GetComponent<RPGTalk>();
        FadeBetweenLevel.RPGTalkBegin = dialogueOption;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
