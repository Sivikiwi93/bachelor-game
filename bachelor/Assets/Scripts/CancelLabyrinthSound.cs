﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelLabyrinthSound : MonoBehaviour
{
    public AudioSource audioSource;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            audioSource.Stop();
        }
    }
}
