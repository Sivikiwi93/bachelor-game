using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoKeyPlay : MonoBehaviour
{
    public AudioClip c;
    AudioSource audioSource;
    public float semitoneOffset;
    public KeyCode key;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Input.GetKeyDown(key))
        {
            PlayKey();
        }
    }

    public void PlayKey()
    {
        audioSource.pitch = Mathf.Pow(2f, semitoneOffset/12.0f);
        audioSource.PlayOneShot(c);
    }
}
