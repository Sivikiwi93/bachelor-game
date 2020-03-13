using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabyrinthGoal : MonoBehaviour
{
    public GameObject laser;
    public LaserGateAudio lga;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (laser.activeInHierarchy)
        {
            lga.TurningOff();
        }
        laser.SetActive(false);

    }
}
