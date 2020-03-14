using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateInstrument : MonoBehaviour
{
    SpriteRenderer sr;
    AudioSource audioSource;

    Color maxAlpha = new Color(255, 255, 255, 255);

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
    }



    public void FillAlpha()
    {
        sr.color = maxAlpha;
    }

    public void PlayInstrument()
    {
        audioSource.Play();
    }

    public void StopInstrument()
    {
        audioSource.Stop();
    }

}
