using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicRandomPick : MonoBehaviour
{

    public AudioClip[] music;
    public AudioSource audioSource;

    private int musicSelection;

    void Start()
    {
        PlayMusic();
    }

    public void PlayMusic()
    {
        musicSelection = Random.Range(0, music.Length);
        audioSource.clip = music[musicSelection];
        audioSource.Play();
    }
}
