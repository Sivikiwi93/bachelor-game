using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockCheckMaterial : MonoBehaviour
{
    public GameObject self;
    public bool verified;

    // Start is called before the first frame update
    void Start()
    {
        verified = false;
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
    }



}
