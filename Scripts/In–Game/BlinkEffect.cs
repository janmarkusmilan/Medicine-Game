using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BlinkEffect : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> highlights1;

    [SerializeField]
    private List<GameObject> highlights2;

    public void FirstAreaBlink()
    {
        for (int i = 0; i < highlights1.Count; i++)
            highlights1[i].SetActive(true);

        StartCoroutine(Blink1(500.0f)); // 500 seconds
    }

    IEnumerator Blink1(float waitTime)
    {
        var endTime = Time.time + waitTime;
        while (Time.time < endTime)
        {
            GetComponent<Renderer>().enabled = false;
            yield return new WaitForSeconds(0.5f); // Render on after 0.5 seconds
            GetComponent<Renderer>().enabled = true;
            yield return new WaitForSeconds(0.5f); // Render off after 0.5 seconds
        }
    }

    public void SecondAreaBlink()
    {
        for (int i = 0; i < highlights2.Count; i++)
            highlights2[i].SetActive(true);

        StartCoroutine(Blink2(500.0f)); // 500 seconds
    }

    IEnumerator Blink2(float waitTime)
    {
        var endTime = Time.time + waitTime;
        while (Time.time < endTime)
        {
            GetComponent<Renderer>().enabled = false;
            yield return new WaitForSeconds(0.5f); // Render on after 0.5 seconds
            GetComponent<Renderer>().enabled = true;
            yield return new WaitForSeconds(0.5f); // Render off after 0.5 seconds
        }
    }
}
