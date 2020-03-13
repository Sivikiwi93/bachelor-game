using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowQ : MonoBehaviour
{
    public GameObject q;
    public PauseMenu piano;

    void Start()
    {
        q.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        q.SetActive(true);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            piano.Pause();
            piano.PianoTime();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        q.SetActive(false);
    }
}
