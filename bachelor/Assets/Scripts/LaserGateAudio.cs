﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserGateAudio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Play start audio of something smashing into a laser
        Debug.Log("Player touched laser");
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        //Play audio loop for laser touching something
        Debug.Log("Player keeps touching the laser");
    }


}
