using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XylophonePlay : MonoBehaviour
{
    SpriteRenderer sr;
    Color col = new Color(255,255,255,255);

    public GameObject laser;
    public LaserGateAudio lga;


    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }


    public void ActivateXylo()
    {
        sr.color = col;

        if (laser.activeInHierarchy)
            {
                lga.TurningOff();
            }
            laser.SetActive(false);
    }
}
