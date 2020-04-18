using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerLogic : MonoBehaviour
{
    public float timeStart;
    public Text textBox;
    private bool isFinish;

    //GameData
    private float[] scores;
    public int hasCompleted;

    void Start()
    {
        scores = new float[3];
        textBox.text = timeStart.ToString("F2");

        for(int i = 0; i < scores.Length; i++)
        {
            scores[i] = PlayerPrefs.GetFloat(i.ToString(), 0);
        }
        System.Array.Sort(scores);
        hasCompleted = PlayerPrefs.GetInt("HasScore", 0);
    }


    void Update()
    {
        if (!isFinish)
        {
            timeStart += Time.deltaTime;
            textBox.text = timeStart.ToString("F2");
        }
    }

    public void SetHighscore()
    {
        isFinish = true;
        PlayerPrefs.SetInt("HasScore", 1);
        hasCompleted = 1;

        for(int i = scores.Length - 1; i >= 0; i--)
        {
            if(i == 0 && timeStart < scores[0])
            {
                scores[2] = scores[1];
                scores[1] = scores[0];
                scores[i] = timeStart;
                PlayerPrefs.SetFloat(0.ToString(), timeStart);
                PlayerPrefs.SetFloat(1.ToString(), scores[1]);
                PlayerPrefs.SetFloat(2.ToString(), scores[2]);
                break;
            }

            if(timeStart < scores[i] && timeStart > scores[i - 1])
            {
                if(i == 1)
                {
                    PlayerPrefs.SetFloat(2.ToString(), scores[i]);
                }

                scores[i] = timeStart;
                PlayerPrefs.SetFloat(i.ToString(), timeStart);
                break;
            }
        }

    }
}
