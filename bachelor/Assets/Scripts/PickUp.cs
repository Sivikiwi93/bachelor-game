using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject item;
    public QToDeactivate ins;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ins.hasInstrument = true;
            item.SetActive(false);
        }
    }
}
