using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footstep : MonoBehaviour
{
    public AudioClip[] steps;
    AudioSource audioSource;
    private int index;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayStep()
    {
        index = Random.Range(0, steps.Length);
        audioSource.PlayOneShot(steps[index]);
    }
}
