using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class FadeBetweenLevel : MonoBehaviour
{
    public Transform player;

    public Image fadeImage;
    public GameObject fadeCanvas;
    public GameObject RPGTalkBegin;

    public AudioSource backgroundMusic;
    public float duration = 5f;
    public float targetVolume = 0f;

    public string sceneName;

    IEnumerator Start()
    {
        player.GetComponent<DialogueAndMovement>().CancelControls();
        fadeImage.canvasRenderer.SetAlpha(1.0f);

        fadeImage.CrossFadeAlpha(0.0f, 3.5f, false);
        yield return new WaitForSeconds(3.5f);
        FadeUnactiveAndBeginDialogue();
    }

    public void FadeUnactiveAndBeginDialogue()
    {
        fadeCanvas.SetActive(false);
        RPGTalkBegin.SetActive(true);
        player.GetComponent<DialogueAndMovement>().GiveBackControls();
        GameObject.Find("[LPC] Cabinet (2)").GetComponent<Interactable>().enabled = false;
    }

    public void StartFadeOut()
    {
        StartCoroutine(FadeOutToNextScene());
    }

    IEnumerator FadeOutToNextScene()
    {
        fadeCanvas.SetActive(true);
        fadeImage.canvasRenderer.SetAlpha(0.0f);
        fadeImage.CrossFadeAlpha(1.0f, 5.0f, false);
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene(sceneName);
    }

    public void FadeOutMusic()
    {
        backgroundMusic = GameObject.Find("Main Camera").GetComponent<AudioSource>();
        StartCoroutine(FadeMusic.StartFade(backgroundMusic, duration, targetVolume));
    }
}
