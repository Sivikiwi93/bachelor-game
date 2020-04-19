using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindBlows : MonoBehaviour
{
    AudioSource audioSource;
    public GameObject laser;
    public LaserGateAudio lga;
    private bool hasEntered;
    private Vector2 offset;

    void Start()
    {
        offset = new Vector2(Random.Range(0.0f, 10.0f), Random.Range(0.0f, 3.0f));
        gameObject.transform.position = offset;

        audioSource = GetComponent<AudioSource>();
        hasEntered = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && hasEntered)
        {
            if (laser.activeInHierarchy)
            {
                lga.TurningOff();
            }
            laser.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(FadeAudio.FadeIn(audioSource, 0.5f, 1));
        hasEntered = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        StartCoroutine(FadeAudio.FadeOut(audioSource, 1f, 0));
        hasEntered = false;
    }
}
