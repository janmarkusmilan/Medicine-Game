using UnityEngine;
using System.Collections;
using RPGTALK.Dub;

public class ToggleDubTutorial : MonoBehaviour
{
    public MonoBehaviour script;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (script.enabled == false)
            {
                script.enabled = true;
                if (RPGTalkDubSounds.aS != null)
                {
                    RPGTalkDubSounds.aS.enabled = true;
                }
            }

            else
            {
                script.enabled = false;
                RPGTalkDubSounds.aS.enabled = false;
            }
        }
    }
}
