﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicVolumeControl : MonoBehaviour
{
    public AudioSource audioSource;
    public Slider slider;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        slider.value = 1.0f;
    }

    public void SetVolume()
    {
        audioSource.volume = slider.value;
    }
}
