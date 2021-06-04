using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class SplashFade : MonoBehaviour
{
    public Image splashImage;

    public string loadMenu;

    IEnumerator Start()
    {
        splashImage.canvasRenderer.SetAlpha(0.0f);

        FadeIn();
        yield return new WaitForSeconds(2.0f);

        FadeOut();
        yield return new WaitForSeconds(2.0f);

        SceneManager.LoadScene(loadMenu);
    }

    public void FadeIn()
    {
        splashImage.CrossFadeAlpha(1.0f, 1.5f, false);
    }

    public void FadeOut()
    {
        splashImage.CrossFadeAlpha(0.0f, 1.5f, false);
    }
}
