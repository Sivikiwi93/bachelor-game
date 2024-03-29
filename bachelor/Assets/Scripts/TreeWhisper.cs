﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System;
using System.Linq;

public class TreeWhisper : MonoBehaviour
{

    public int thisTreeNr;
    public int nextWhisperNr = 0;
    private bool hasEntered;
    AudioSource audioSource;
    public AudioClip correct;

    public WhisperRandom whisp;
    int[] treeOrder;


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = 0;
        hasEntered = false;
    }

    private void Update()
    {
        if (hasEntered && Input.GetKeyDown(KeyCode.Q))
        {
            if (treeOrder[nextWhisperNr] == thisTreeNr)
            {
                audioSource.PlayOneShot(correct);
                whisp.Increment();
                StopWhisper();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        hasEntered = true;
        GetTreeNr();

        if(collision.CompareTag("Player") && treeOrder[nextWhisperNr] == thisTreeNr)
        {
            PlayWhisper();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        hasEntered = false;
        GetTreeNr();

        if (collision.CompareTag("Player") && audioSource.isPlaying)
        {
            StopWhisper();
        }
    }

    public void GetTreeNr()
    {
        treeOrder = whisp.order;
        nextWhisperNr = whisp.turnInOrder;
    }

    public void PlayWhisper()
    {
        StartCoroutine(FadeAudio.FadeIn(audioSource, 0.25f, 1));
        audioSource.pitch 
        = Random.Range(0.6f, 1.7f);
    }

    public void StopWhisper()
    {
        StartCoroutine(FadeAudio.FadeOut(audioSource, 0.25f, 0));
    }
}
