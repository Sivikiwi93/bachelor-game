using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindBlows : MonoBehaviour
{
    AudioSource audioSource;
    public GameObject laser;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            laser.SetActive(false);
            //audioSource.PlayOneShot(LaserOff);
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        audioSource.Play();
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        audioSource.Stop();
    }
}
