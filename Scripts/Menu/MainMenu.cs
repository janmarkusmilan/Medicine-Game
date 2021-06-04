using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour
{
    public AudioSource myFX;
    public AudioClip hoverFX;
    public AudioClip clickFX;

    public Image fadeImage;
    public GameObject fadeCanvas;

    public AudioSource backgroundMusic;
    public float duration = 5f;
    public float targetVolume = 0f;

    public string sceneName;
    public bool fadeConfirm = true;

    IEnumerator Start()
    {
        if (fadeConfirm)
        {
            fadeImage.canvasRenderer.SetAlpha(1.0f);

            fadeImage.CrossFadeAlpha(0.0f, 3.5f, false);
            yield return new WaitForSeconds(3.5f);
            fadeCanvas.SetActive(false);
        }

        fadeConfirm = false;
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

    public void HoverSound()
    {
        myFX.PlayOneShot(hoverFX);
    }

    public void ClickSound()
    {
        myFX.PlayOneShot(clickFX);
    }

    public void QuitGame()
    {
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
