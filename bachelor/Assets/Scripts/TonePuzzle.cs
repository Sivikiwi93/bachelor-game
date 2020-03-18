using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class TonePuzzle : MonoBehaviour
{
    public float[] bushOrder = new float[4];
    private float[] setOrder = {1.0f, 1.1f, 1.25f, 1.3f};
    private int counter;

    public GameObject laser;
    public LaserGateAudio lga;

    AudioSource audioSource;
    public AudioClip wrong;
    public AudioClip correct;


    private void Start()
    {
        counter = 0;
        audioSource = GetComponent<AudioSource>();
    }

    public void AddAndCheckList(float note)
    {
        bushOrder[counter] = note;
        counter++;

        if (counter == 4)
        {
            if(Enumerable.SequenceEqual(bushOrder, setOrder))
            {
                audioSource.PlayOneShot(correct);

                if (laser.activeInHierarchy)
                {
                    lga.TurningOff();
                }

                laser.SetActive(false);
                counter = 0;
                Array.Clear(bushOrder, 0, 4);
            }
            else
            {
                audioSource.PlayOneShot(wrong);
                Array.Clear(bushOrder, 0, 4);
                counter = 0;
            }
        }
    }
}
