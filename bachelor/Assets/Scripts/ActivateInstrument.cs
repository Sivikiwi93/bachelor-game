using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateInstrument : MonoBehaviour
{
    SpriteRenderer sr;
    AudioSource audioSource;
    public bool isPlaying;


    Color maxAlpha = new Color(255, 255, 255, 255);

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
        isPlaying = false;
    }



    public void FillAlpha()
    {
        sr.color = maxAlpha;
    }

    public void PlayInstrument()
    {
        audioSource.Play();
        isPlaying = true;
    }

    public void StopInstrument()
    {
        isPlaying = false;
        audioSource.Stop();
    }

}
