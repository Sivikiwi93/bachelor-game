using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlRoomVolume : MonoBehaviour
{

    public AudioSource music;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(FadeAudio.FadeMusic(music, 0.25f, 0.2f));
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(FadeAudio.FadeMusic(music, 0.25f, 0.7f));
        }
    }

}
