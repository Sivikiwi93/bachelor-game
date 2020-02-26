using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockCheckMaterial : MonoBehaviour
{
    public GameObject self;
    public AudioSource audioSource;
    Rigidbody2D rb;

    public bool verified;
    private bool isMoving;


    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        verified = false;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (rb.velocity.magnitude > 0.1 && !isMoving)
        {
            //Play drag nioce
            Debug.Log("Rock is push");
            isMoving = true;
        } else if (rb.velocity.magnitude <= 0.1 && isMoving)
        {
            Debug.Log("Rock is stop");
            isMoving = false;
        }


    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("AudioSwitchGrass") && self.CompareTag("AudioSwitchGrass"))
        {
            verified = true;
        }
        else if (collision.CompareTag("AudioSwitchWater") && self.CompareTag("AudioSwitchWater"))
        {
            verified = true;
        }
        else if (collision.CompareTag("AudioSwitchFire") && self.CompareTag("AudioSwitchFire"))
        {
            verified = true;
        }
        else if (collision.CompareTag("AudioSwitchSand") && self.CompareTag("AudioSwitchSand"))
        {
            verified = true;
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            audioSource.Play();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("AudioSwitchGrass") && self.CompareTag("AudioSwitchGrass"))
        {
            verified = false;
        }
        else if (collision.CompareTag("AudioSwitchWater") && self.CompareTag("AudioSwitchWater"))
        {
            verified = false;
        }
        else if (collision.CompareTag("AudioSwitchFire") && self.CompareTag("AudioSwitchFire"))
        {
            verified = false;
        }
        else if (collision.CompareTag("AudioSwitchSand") && self.CompareTag("AudioSwitchSand"))
        {
            verified = false;
        }



        if (collision.CompareTag("Player"))
        {
            audioSource.Stop();
        }

    }



}
