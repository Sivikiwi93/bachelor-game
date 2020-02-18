using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSignHotkey : MonoBehaviour
{
    public GameObject pressQ;
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
                pressQ.SetActive(false);
            }
        }
    }

    void DisplayQ()
    {
        timerDisplay = displayTime;
        pressQ.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Touched sign");
        DisplayQ();
        
    }

}
