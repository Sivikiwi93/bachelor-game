using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSignHotkey : MonoBehaviour
{
    public GameObject text;
    public GameObject signText;
    public GameObject q;

    public float displayTime = 6.0f;
    float timerDisplay;
    private bool hasEntered;


    void Start()
    {
        q.SetActive(false);
        timerDisplay = -1.0f;
        hasEntered = false;
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

        if (Input.GetKeyDown(KeyCode.Q) && hasEntered)
        {
            q.SetActive(false);
            DisplayObject(text);
            DisplayObject(signText);
        }
    }

    void DisplayObject(GameObject obj)
    {
        timerDisplay = displayTime;
        obj.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        DisplayObject(q);
        hasEntered = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        q.SetActive(false);
        hasEntered = false;
    }
}
