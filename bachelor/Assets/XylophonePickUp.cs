using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XylophonePickUp2 : MonoBehaviour
{
    public GameObject gameObject;
    public XylophonePlay xp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.SetActive(false);
        xp.ActivateXylo();

    }
}
