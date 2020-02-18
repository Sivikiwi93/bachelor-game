using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindBlows : MonoBehaviour
{
    AudioSource audioSource;
    public GameObject laser;
    public LaserGateAudio lga;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            lga.TurningOff();
            laser.SetActive(false);
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        audioSource.Play();
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        audioSource.Stop();
    }
}
