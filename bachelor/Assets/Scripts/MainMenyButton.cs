using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenyButton : MonoBehaviour
{
    public RectTransform size;
    private float width;
    private float height;

    public AudioSource audioSource;
    public AudioClip hover;
    public AudioClip click;


    private void Start()
    {
        width = size.rect.width;
        height = size.rect.height;
    }

    public void SizeUp()
    {
        audioSource.pitch = Random.Range(1.0f, 1.25f);
        audioSource.PlayOneShot(hover);
        size.sizeDelta = new Vector2(width + 30f, height + 20f);
    }

    public void SizeDown()
    {
        audioSource.pitch = -1;
        audioSource.PlayOneShot(hover);
        size.sizeDelta = new Vector2(width, height);
    }

    public void Click()
    {
        audioSource.PlayOneShot(click);

    }
}
