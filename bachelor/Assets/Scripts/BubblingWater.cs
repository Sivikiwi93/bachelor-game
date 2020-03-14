using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BubblingWater : MonoBehaviour
{
    AudioSource audioSource;

    public TileBase water;
    public TileBase sand;
    public Tilemap tilemap;

    public AudioClip flushSFX;

    private bool isFlush;
    private bool hasEntered;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        isFlush = false;
        hasEntered = false;
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && hasEntered)
        {
            audioSource.Stop();
            isFlush = true;
            tilemap.SwapTile(water, sand);
            audioSource.PlayOneShot(flushSFX);
        }
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        hasEntered = true;

        if (!isFlush)
        {
            audioSource.Play();
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        hasEntered = false;

        if (!isFlush)
        {
            audioSource.Stop();
        }
    }
}
