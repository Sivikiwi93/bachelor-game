using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserGateAudio : MonoBehaviour
{

    public AudioSource audioSource;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Player touched the laser");
        }
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("Player keeps touching the laser");
        }
        
    }

    public void TurningOff()
    {
        audioSource.Play();
    }

}
