using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserGateAudio : MonoBehaviour
{
    public AudioSource audioSource;


    public void TurningOff()
    {
        audioSource.Play();
    }
}
