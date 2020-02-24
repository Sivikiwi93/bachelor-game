using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValidateRocks : MonoBehaviour
{
    public RockCheckMaterial water;
    public RockCheckMaterial fire;
    public RockCheckMaterial sand;
    public RockCheckMaterial grass;

    public GameObject laser;
    public LaserGateAudio lga;

    private bool audioPlayed;

    void Start()
    {
        audioPlayed = false;
    }


    // Update is called once per frame
    void Update()
    {
        if(grass.verified && sand.verified && fire.verified && water.verified && !audioPlayed)
        {
            lga.TurningOff();
            audioPlayed = true;
            laser.SetActive(false);
        }   
    }
}
