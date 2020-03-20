﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWin : MonoBehaviour
{
    private bool startCountdown;
    private float timer = 4.0f;
    public GameObject winText;


    private void Start()
    {
        startCountdown = false;
        winText.SetActive(false);
    }

    private void Update()
    {
        if (startCountdown)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                SceneManager.LoadScene(0);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            winText.SetActive(true);
            startCountdown = true;
        }
    }
}