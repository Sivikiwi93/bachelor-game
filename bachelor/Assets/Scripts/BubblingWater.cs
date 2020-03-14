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

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        isFlush = false;
    }


    void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            audioSource.Stop();
            isFlush = true;
            tilemap.SwapTile(water, sand);
            audioSource.PlayOneShot(flushSFX);
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isFlush)
        {
            audioSource.Play();
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (!isFlush)
        {
            audioSource.Stop();
        }
    }
}
