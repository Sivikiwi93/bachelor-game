using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BubblingWater : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip flushSFX;

    public TileBase water;
    public TileBase sand;
    public TileBase waterFade1;
    public TileBase waterFade2;
    public Tilemap tilemap;

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
            audioSource.PlayOneShot(flushSFX);
            StartCoroutine(WaterFade(water, waterFade1, waterFade2, sand));
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

    IEnumerator WaterFade(TileBase tile1, TileBase tile2, TileBase tile3, TileBase tile4)
    {
        yield return new WaitForSeconds(0.5f);
        tilemap.SwapTile(tile1, tile2);
        yield return new WaitForSeconds(0.5f);
        tilemap.SwapTile(tile2, tile3);
        yield return new WaitForSeconds(0.5f);
        tilemap.SwapTile(tile3, tile4);
    }
}
