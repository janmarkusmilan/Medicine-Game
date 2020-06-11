using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using RPGTALK.Localization; // Might change language

public class DialogueAndMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D body;
    public Animator animator;

    Vector2 movement;

    // The user can move the character?
    public bool controls;

    // We will sometimes initialize the talk by script, so let's keep a instance of the current RPGTalk
    public RPGTalk rpgTalk;
    public RPGTalkLanguage languageEN;

    //public GameObject wall, wall2;
    public GameObject particle;
    public GameObject finalArea;
    //public UnityEvent sceneOneEnd, sceneTwoEnd, finalSceneEnd; // References

    // Update is called once per frame
    void Update()
    {
        // Skip the Talk to the end if the player hits Y
        if (Input.GetKeyDown(KeyCode.Y))
        {
            rpgTalk.EndTalk();
        }

        if (controls)
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
            movement = movement.normalized;

            if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
            {
                animator.SetFloat("Horizontal", movement.x);
                animator.SetFloat("Vertical", movement.y);
            }
            animator.SetFloat("Speed", movement.sqrMagnitude);
        }
    }

    void FixedUpdate()
    {
        body.MovePosition(body.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    // The player can't move
    public void CancelControls()
    {
        controls = false;
        moveSpeed = 0f;
        GetComponent<Animator>().enabled = false;
    }

    // Give back the controls to player
    public void GiveBackControls()
    {
        controls = true;
        moveSpeed = 5f;
        GetComponent<Animator>().enabled = true;
    }

    public void ByeWall()
    {
        GameObject.Find("Wall").SetActive(false);
        GameObject.Find("[LPC] Cabinet (2)").GetComponent<Interactable>().enabled = false;
    }

    public void EnableScript()
    {
        GameObject.Find("[LPC] Cabinet (2)").GetComponent<Interactable>().enabled = true;
    }

    public void DisableScript()
    {
        GameObject.Find("[LPC] Cabinet (2)").GetComponent<Interactable>().enabled = false;
    }

    public void ByeWall2()
    {
        GameObject.Find("Wall2").SetActive(false);
    }

    public void FinalDialogueOn()
    {
        finalArea.SetActive(true);
    }

    public void ParticleOn()
    {
        particle.SetActive(true);
    }
}