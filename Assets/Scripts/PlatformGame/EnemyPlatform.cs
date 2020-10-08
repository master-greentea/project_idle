﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class EnemyPlatform : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D activator) {
        // player death when enter enemy trigger
        if (activator == GameObject.Find("Elon").GetComponent<BoxCollider2D>()) {
            Debug.Log("1x");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
        }
    }
}
