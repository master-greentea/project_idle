using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D activator) {
        if (activator.tag == "Player") {
            SceneManager.LoadScene("Game");
        }
    }
}
