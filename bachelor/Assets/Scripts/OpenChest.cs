using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour
{

    public Sprite openChest;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
       sr = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        sr.sprite = openChest;
    }
}