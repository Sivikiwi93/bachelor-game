using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class TonePuzzle : MonoBehaviour
{

    public float[] bushOrder = new float[4];
    private float[] setOrder = {1.0f, 1.1f, 1.25f, 1.3f};
    private int counter;

    public GameObject laser;
    public LaserGateAudio lga;

    private void Start()
    {
        counter = 0;

    }


    public void AddAndCheckList(float note)
    {

        bushOrder[counter] = note;
        counter++;

        if (counter == 4)
        {
            if(Enumerable.SequenceEqual(bushOrder, setOrder))
            {
                lga.TurningOff();
                laser.SetActive(false);

                Debug.Log("Shit Works with the combobroooo!!!!!");
                counter = 0;
                Array.Clear(bushOrder, 0, 4);
            }
            else
            {
                //Spill lyd som sier feil
                Array.Clear(bushOrder, 0, 4);
                counter = 0;
            }
        }
    }
}
