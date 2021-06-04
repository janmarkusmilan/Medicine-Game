using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MusicToggle : MonoBehaviour
{
    AudioSource backgroundMusic;

    public Button musicToggle;
    bool musicOn;

    void Start()
    {
        musicOn = true;
        backgroundMusic = Camera.main.GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (backgroundMusic.isPlaying)
                backgroundMusic.Pause();

            else
                backgroundMusic.Play();
        }
    }

    public void PauseAndPlayMusic()
    {
        if (musicOn)
        {
            musicOn = false;
            backgroundMusic.Pause();
        }
        else
        {
            musicOn = true;
            backgroundMusic.Play();
        }
    }
}