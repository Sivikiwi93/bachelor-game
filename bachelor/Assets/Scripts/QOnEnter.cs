using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QOnEnter : MonoBehaviour
{
    public GameObject q;

    void Start()
    {
        q.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        q.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        q.SetActive(false);
    }
}
