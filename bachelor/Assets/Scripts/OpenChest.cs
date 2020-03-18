using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour
{
    public Sprite openChest;
    public bool isOpen;
    public GameObject chestItem;

    AudioSource audioSource;
    SpriteRenderer sr;


    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
        isOpen = false;
        chestItem.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isOpen)
        {
            sr.sprite = openChest;
            isOpen = true;
            chestItem.SetActive(true);
        }
    }

    public void PickUpSound(AudioClip sound)
    {
        audioSource.PlayOneShot(sound);
    }
}