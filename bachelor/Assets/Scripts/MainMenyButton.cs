using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenyButton : MonoBehaviour
{
    public RectTransform size;
    private float width;
    private float height;


    private void Start()
    {
        width = size.rect.width;
        height = size.rect.height;
    }

    public void SizeUp()
    {
        size.sizeDelta = new Vector2(width + 30f, height + 20f);
    }

    public void SizeDown()
    {
        size.sizeDelta = new Vector2(width, height);
    }
}
