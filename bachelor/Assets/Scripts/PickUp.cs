using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject item;
    public QToDeactivate ins;
    public OpenChest chest;
    public AudioClip pickUpSound;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            chest.PickUpSound(pickUpSound);
            ins.hasInstrument = true;
            item.SetActive(false);
        }
    }
}
