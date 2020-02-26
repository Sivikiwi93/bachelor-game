using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ResetRockPosition : MonoBehaviour
{
    Vector3 originalPos;


    private void Start()
    {
        originalPos = gameObject.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Wall"))
        {
            gameObject.transform.position = originalPos;
        }
    }
}