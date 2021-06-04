using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;

public class DetermineNPC : MonoBehaviour
{
    public static string[] presentNPCS = { "NPC Mia", "NPC Laura", "NPC Kelly", "NPC Sarah", "NPC Jake", "NPC Connor", "NPC Ryan", "NPC Eden", "NPC Luna", "NPC Jamie" };
    public static string[] backup = { "NPC Mia", "NPC Laura", "NPC Kelly", "NPC Sarah", "NPC Jake", "NPC Connor", "NPC Ryan", "NPC Eden", "NPC Luna", "NPC Jamie" };

    private void Awake()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("ChooseNPC");
        if (objects.Length > 1)
            Destroy(this.gameObject);
        DontDestroyOnLoad(this);
    }
}
