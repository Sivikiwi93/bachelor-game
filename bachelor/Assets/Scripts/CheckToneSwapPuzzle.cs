using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckToneSwapPuzzle : MonoBehaviour
{
    public PlayAndSwapTone tone1;
    public PlayAndSwapTone tone2;
    public PlayAndSwapTone tone3;

    public DeactivateLaser laser;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            tone1.Activate();
            tone2.Activate();
            tone3.Activate();

            CheckValidation();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            tone1.Deactivate();
            tone2.Deactivate();
            tone3.Deactivate();
        }
    }

    private void CheckValidation()
    {
        if (tone1.isCorrect && tone2.isCorrect && tone3.isCorrect)
        {
            laser.Deactivate();
        }
    }

}
