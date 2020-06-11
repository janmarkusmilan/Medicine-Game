using UnityEngine;
using System.Collections;
using RPGTALK.Dub;

public class ToggleDub : MonoBehaviour
{
    public MonoBehaviour script;

    public GameObject obj;
    public string scriptName;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (script.enabled == false)
            {
                script.enabled = true;
                (obj.GetComponent(scriptName) as MonoBehaviour).enabled = true;
                if (RPGTalkDubSounds.aS != null)
                {
                    RPGTalkDubSounds.aS.enabled = true;
                }
            }

            else
            {
                script.enabled = false;
                (obj.GetComponent(scriptName) as MonoBehaviour).enabled = false;
                RPGTalkDubSounds.aS.enabled = false;
            }
        }
    }
}
