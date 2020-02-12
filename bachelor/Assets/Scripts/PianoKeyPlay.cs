using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoKeyPlay : MonoBehaviour
{

    public AudioClip c;
    AudioSource audioSource;
    public float semitoneOffset;

    public KeyCode key;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
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
