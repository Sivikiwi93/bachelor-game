using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QToDeactivate : MonoBehaviour
{
    private bool hasEntered;
    public DeactivateLaser laser;
    public ActivateInstrument ins;

    public bool hasInstrument;


    void Start()
    {
        hasEntered = false;
        hasInstrument = false;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q) && hasEntered && hasInstrument)
        {
            laser.Deactivate();
            ins.FillAlpha();
            if (ins.isPlaying)
            {
                ins.StopInstrument();
            } else
            {
                ins.PlayInstrument();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        hasEntered = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        hasEntered = false;
    }
}
