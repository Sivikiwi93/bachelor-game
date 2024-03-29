﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Labyrinth : MonoBehaviour
{
    AudioSource audioSource;
    public AudioSource music;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            audioSource.Play();
            StartCoroutine(FadeAudio.FadeMusic(music, 0.25f, 0.2f));
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && audioSource.isPlaying)
        {
            StartCoroutine(FadeAudio.FadeMusic(music, 0.25f, 0.7f));
            audioSource.Stop();
        }
    }
}
