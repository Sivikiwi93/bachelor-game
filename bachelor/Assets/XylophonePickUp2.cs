using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XylophonePickUp : MonoBehaviour
{

    public GameObject gameObject;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.SetActive(false);
    }
}
