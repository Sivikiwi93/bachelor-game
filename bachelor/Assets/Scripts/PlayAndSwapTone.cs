using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAndSwapTone : MonoBehaviour
{
    AudioSource tone;

    public float semitoneOffset;
    public float desiredOffset;
    public float[] range;
    public bool isCorrect;

    private int rangeIndex;
    private bool hasEntered;


    private void Start()
    {
        tone = GetComponent<AudioSource>();
        isCorrect = false;
        rangeIndex = 0;
        ChangePitch();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && hasEntered)
        {
            if (rangeIndex >= 2)
            {
                rangeIndex = -1;
            }

            rangeIndex++;
            semitoneOffset = range[rangeIndex];
            ChangePitch();

            if (semitoneOffset == desiredOffset)
            {
                isCorrect = true;
            }
            else
            {
                isCorrect = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            hasEntered = true;
            Activate();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        hasEntered = false;
        Deactivate();
    }

    private void ChangePitch()
    {
        tone.pitch = Mathf.Pow(2f, semitoneOffset / 12.0f);
    }

    public void Activate()
    {
        StartCoroutine(FadeAudio.FadeIn(tone, 0.25f, 1));
    }

    public void Deactivate()
    {
        StartCoroutine(FadeAudio.FadeOut(tone, 0.25f, 0));
    }
}
