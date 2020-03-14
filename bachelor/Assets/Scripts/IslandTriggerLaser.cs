using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandTriggerLaser : MonoBehaviour
{

    public DeactivateLaser laser;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            laser.Deactivate();
        }
    }
}
