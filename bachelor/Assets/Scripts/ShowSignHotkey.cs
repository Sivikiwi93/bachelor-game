using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSignHotkey : MonoBehaviour
{
    public GameObject text;
    public GameObject signText;
    public float displayTime = 2.0f;
    float timerDisplay;

    void Start()
    {
        //pressQ.SetActive(false);
        timerDisplay = -1.0f;
    }

    void Update()
    {
        if(timerDisplay >= 0)
        {
            timerDisplay -= Time.deltaTime;
            if(timerDisplay < 0)
            {
                text.SetActive(false);
                signText.SetActive(false);
            }
        }
    }

    void DisplayObject(GameObject obj)
    {
        timerDisplay = displayTime;
        obj.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Touched sign");
        //DisplayObject(pressQ);
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            DisplayObject(text);
            DisplayObject(signText);
        }
    }
}
