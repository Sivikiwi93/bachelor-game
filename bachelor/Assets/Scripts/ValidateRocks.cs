using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValidateRocks : MonoBehaviour
{
    public RockCheckMaterial water;
    public RockCheckMaterial fire;
    public RockCheckMaterial sand;

    public GameObject laser;
    public LaserGateAudio lga;

    private bool audioPlayed;


    void Start()
    {
        audioPlayed = false;
    }

    void Update()
    {
        if(sand.verified && fire.verified && water.verified && !audioPlayed)
        {
            lga.TurningOff();
            audioPlayed = true;
            laser.SetActive(false);
        }   
    }
}
