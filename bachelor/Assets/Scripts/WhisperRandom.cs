using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhisperRandom : MonoBehaviour
{

    public GameObject[] trees;
    public int[] order;
    public int nrOfWhispers = 4;
    public int[] empty;
    public int turnInOrder;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CreateOrder();
        turnInOrder = 0;
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
    }

    public void ClearOrder(int[] list)
    {
        list = empty;
    }

    public int SendNextTree()
    {
        return order[turnInOrder];
        turnInOrder++;
    }

}
