using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhisperRandom : MonoBehaviour
{
    public GameObject[] trees;
    public GameObject laser;
    public LaserGateAudio lga;

    public int[] order;
    public int nrOfWhispers;
    public int turnInOrder;

    private bool isComplete;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CreateOrder();
        turnInOrder = 0;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(isComplete)
        {
            if (laser.activeInHierarchy)
            {
                lga.TurningOff();
            }
            laser.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        ClearOrder(order);
        turnInOrder = 0;
    }

    public void CreateOrder()
    {
        for (int i = 0; i < nrOfWhispers; i++)
        {
            order[i] = Random.Range(0, trees.Length);
        }
        Debug.Log(order);
    }

    public void ClearOrder(int[] list)
    {
        for (int i = 0; i < nrOfWhispers; i++)
        {
            order[i] = 0;
        }
        turnInOrder = 0;
    }

    public void Increment()
    {
        turnInOrder++;
        if(turnInOrder >= nrOfWhispers)
        {
            isComplete = true;
            turnInOrder = 0;
        }
    }

}
