using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabyrinthGoal : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip goal;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        audioSource.PlayOneShot(goal);
        //Unlock next path
    }
}
