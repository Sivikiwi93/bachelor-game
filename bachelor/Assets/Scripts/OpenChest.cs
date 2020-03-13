using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour
{

    public Sprite openChest;
    SpriteRenderer sr;
    public bool isOpen;

    public GameObject chestItem;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        isOpen = false;
        chestItem.SetActive(false);
        
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isOpen)
        {
            sr.sprite = openChest;
            isOpen = true;
            chestItem.SetActive(true);
        }
    }
}