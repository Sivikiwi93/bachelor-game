using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetHighScores : MonoBehaviour
{

    public Text header;
    public int hasUnlocked;
    private float[] scores;
    public GameObject scoreInfo;
    public Text score1;
    public Text score2;
    public Text score3;

    void Start()
    {
        hasUnlocked = PlayerPrefs.GetInt("HasScore", 0);
        scores = new float[3];

        for(int i = 0; i < scores.Length; i++)
        {
            scores[i] = PlayerPrefs.GetFloat(i.ToString(), 0);
        }

        if(scores[1] == 10000f)
        {
            score1.text = scores[0].ToString("F2");
            score2.text = "X";
            score3.text = "X";
        } else if (scores[2] == 10000f)
        {
            score1.text = scores[0].ToString("F2");
            score2.text = scores[1].ToString("F2");
            score3.text = "X";
        } else
        {
            score1.text = scores[0].ToString("F2");
            score2.text = scores[1].ToString("F2");
            score3.text = scores[2].ToString("F2");
        }
    }

    void Update()
    {
        hasUnlocked = PlayerPrefs.GetInt("HasScore", 0);

        if (hasUnlocked == 1)
        {
            header.text = "HIGH SCORES";
            scoreInfo.SetActive(true);

            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = PlayerPrefs.GetFloat(i.ToString(), 0);
            }
        } 
        else
        {
            header.text = "???";
            scoreInfo.SetActive(false);
        }
    }

    public void ResetScore()
    {
        PlayerPrefs.SetInt("HasScore", 0);
        PlayerPrefs.SetFloat("0", 10000f);
        PlayerPrefs.SetFloat("1", 10000f);
        PlayerPrefs.SetFloat("2", 10000f);
    }
}
