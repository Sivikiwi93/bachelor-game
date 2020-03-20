using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockMarkerSound : MonoBehaviour
{
    public AudioSource audioSource;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(FadeAudio.FadeIn(audioSource, 0.5f, 1));
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(FadeAudio.FadeOut(audioSource, 0.25f, 1));
        }
    }
}
