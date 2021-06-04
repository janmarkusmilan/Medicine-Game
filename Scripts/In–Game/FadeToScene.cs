using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class FadeToScene : MonoBehaviour
{
    public Image fadeImage;
    public GameObject fadeCanvas;

    public string sceneName;

    public void StartFadeOut()
    {
        StartCoroutine(FadeOutToScene());
    }

    IEnumerator FadeOutToScene()
    {
        fadeCanvas.SetActive(true);
        fadeImage.canvasRenderer.SetAlpha(0.0f);
        fadeImage.CrossFadeAlpha(1.0f, 5.0f, false);
        yield return new WaitForSeconds(5.0f);

        SceneManager.LoadScene(sceneName);
    }
}
