﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class TreeWhisper : MonoBehaviour
{

    public int thisTreeNr;
    public int nextWhisperNr;
    AudioSource audioSource;


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") && nextWhisperNr == thisTreeNr)
        {
            PlayWhisper();
        }
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && Input.GetKeyDown(KeyCode.Q))
        {
            if (nextWhisperNr == thisTreeNr)
            {

            }

        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && audioSource.isPlaying)
        {
            StopWhisper();
        }
    }


    public void GetTreeNr(int nr)
    {
        nextWhisperNr = nr;
    }

    public void PlayWhisper()
    {
        audioSource.Play();
    }

    public void StopWhisper()
    {
        audioSource.Stop();
    }

}