using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockCheckMaterial : MonoBehaviour
{
    public GameObject self;

    public AudioSource audioSource;

    public bool verified;
    //private bool isOn = false;



    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        verified = false;
        //audioSource.loop = isOn;
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
