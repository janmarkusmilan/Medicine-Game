using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class FadeRandomly : MonoBehaviour
{
    public Image fadeImage;
    public GameObject fadeCanvas;

    private const int kNumScenes = 12; //Highest number of scene index for easy levels
    private static List<int> s_SceneList = null;

    private const int kNumScenesHard = 22; //Highest number of scene index for hard levels
    private static List<int> s_SceneListHard = null;

    public void StartRandomFadeOut()
    {
        StartCoroutine(FadeOutToRandomScene());
    }

    IEnumerator FadeOutToRandomScene()
    {
        fadeCanvas.SetActive(true);
        fadeImage.canvasRenderer.SetAlpha(0.0f);
        fadeImage.CrossFadeAlpha(1.0f, 5.0f, false);
        yield return new WaitForSeconds(5.0f);

        if (s_SceneList == null)
        {
            s_SceneList = new List<int>();

            for (int i = 3; i <= kNumScenes; i++)
            {
                s_SceneList.Add(i);
            }
            for (int i = 0; i < s_SceneList.Count; i++)
            {
                int index = Random.Range(0, s_SceneList.Count);
                s_SceneList.Add(s_SceneList[index]);
                s_SceneList.RemoveAt(index);
            }
        }

        if (s_SceneList.Count >= 1)
        {
            int sceneNum = s_SceneList[0];
            s_SceneList.RemoveAt(0);
            SceneManager.LoadScene(sceneNum);
        }

        else //if (s_SceneList.Count < 1)
        {
            s_SceneList = null;
            SceneManager.LoadScene("99) Closing");
        }
    }

    public void StartRandomFadeOutHard()
    {
        StartCoroutine(FadeOutToRandomSceneHard());
    }

    IEnumerator FadeOutToRandomSceneHard()
    {
        fadeCanvas.SetActive(true);
        fadeImage.canvasRenderer.SetAlpha(0.0f);
        fadeImage.CrossFadeAlpha(1.0f, 5.0f, false);
        yield return new WaitForSeconds(5.0f);

        if (s_SceneListHard == null)
        {
            s_SceneListHard = new List<int>();

            for (int i = 13; i <= kNumScenesHard; i++)
            {
                s_SceneListHard.Add(i);
            }
            for (int i = 0; i < s_SceneListHard.Count; i++)
            {
                int index2 = Random.Range(0, s_SceneListHard.Count);
                s_SceneListHard.Add(s_SceneListHard[index2]);
                s_SceneListHard.RemoveAt(index2);
            }
        }

        if (s_SceneListHard.Count >= 1)
        {
            int sceneNum2 = s_SceneListHard[0];
            s_SceneListHard.RemoveAt(0);
            SceneManager.LoadScene(sceneNum2);
        }

        else //if (s_SceneList.Count < 1)
        {
            s_SceneListHard = null;
            SceneManager.LoadScene("99) Closing");
        }
    }
}
