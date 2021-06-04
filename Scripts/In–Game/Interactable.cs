using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{
    public Image FKey;

    public Transform player;
    public float radius;

    public GameObject inventory;
    public GameObject information;

    public bool keyTrigger = false;

    void Start()
    {
        FKey.gameObject.SetActive(false);
        inventory.SetActive(false);
        information.SetActive(false);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    void Update()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);
        if (distance <= radius)
        {
            FKey.gameObject.SetActive(true);

            if (Input.GetKeyDown(KeyCode.F))
            {
                if (keyTrigger == false)
                {
                    inventory.SetActive(true);
                    information.SetActive(true);
                    player.GetComponent<DialogueAndMovement>().CancelControls();
                }
                
                keyTrigger = true;
            }               
        }
        else
        {
            FKey.gameObject.SetActive(false);
            inventory.SetActive(false);
            information.SetActive(false);
        }
    }

    public void setBoolKeyTrigger()
    {
        keyTrigger = false;
    }
}
