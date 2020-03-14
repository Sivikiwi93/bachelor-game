using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindBlows : MonoBehaviour
{
    AudioSource audioSource;
    public GameObject laser;
    public LaserGateAudio lga;
    private bool hasEntered;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        hasEntered = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && hasEntered)
        {
            if (laser.activeInHierarchy)
            {
                lga.TurningOff();
            }
            laser.SetActive(false);
        }
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        audioSource.Play();
        hasEntered = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        audioSource.Stop();
        hasEntered = false;
    }
}
