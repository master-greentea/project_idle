using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opener : MonoBehaviour
{
    public bool open;
    public GameObject sputify;
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        if (open) {
            sputify.SetActive(true);
        }
        else {
            sputify.SetActive(false);
        }
    }
}
