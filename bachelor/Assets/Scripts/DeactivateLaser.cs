using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateLaser : MonoBehaviour
{

    public GameObject laser;
    public LaserGateAudio lga;





    public void Deactivate()
    {
        if (laser.activeInHierarchy)
        {
            lga.TurningOff();
        }
        laser.SetActive(false);
    }
}
