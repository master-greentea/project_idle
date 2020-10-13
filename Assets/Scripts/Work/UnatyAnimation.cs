using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnatyAnimation : MonoBehaviour
{
    Animator myAnime;

    void Start()
    {
        myAnime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) {
            myAnime.SetBool("working", true);
        }
        else {
            myAnime.SetBool("working", false);
        }
    }
}
