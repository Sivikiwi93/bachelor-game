using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowQ : MonoBehaviour
{
    public GameObject q;
    public PauseMenu piano;

    private bool hasEntered;

    void Start()
    {
        q.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && hasEntered)
        {
            piano.Pause();
            piano.PianoTime();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        q.SetActive(true);
        hasEntered = true;
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        q.SetActive(false);
        hasEntered = false;
    }
}
