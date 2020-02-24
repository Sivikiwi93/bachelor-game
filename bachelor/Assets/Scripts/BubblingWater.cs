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

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            tilemap.SwapTile(water, sand);
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
