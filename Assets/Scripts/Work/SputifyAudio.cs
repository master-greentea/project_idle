using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SputifyAudio : MonoBehaviour
{
    private AudioSource myAduio;
    private GameObject cam;
    public AudioClip clip;
    public bool playSong;
    void Start() {
        cam = GameObject.Find("Main Camera");
        myAduio = cam.GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        myAduio.Stop();
        if (playSong) {
            myAduio.clip = clip;
            myAduio.Play();
        }
    }
}
