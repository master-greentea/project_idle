using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChordPlayer : MonoBehaviour
{
    // put under individual chord
    // animation
    Animator myAni;
    // chord audio
    AudioSource myChord;
    void Start()
    {
        myAni = GameObject.Find("String").GetComponent<Animator>();
        myChord = GetComponent<AudioSource>();
    }

    void Update()
    {
        // stop animation if no chord is playing
        if (Input.GetMouseButtonUp(0)) {
            myAni.SetBool("playing", false);
        }
    }
    
    void OnMouseDown()
    {
        // if chord playing, do animation
        Debug.Log("click");
        myAni.SetBool("playing", true);

        // play chord
        myChord.Play();
    }

}
