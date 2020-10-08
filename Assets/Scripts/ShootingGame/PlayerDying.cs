using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDying : MonoBehaviour
{
    // IMPORTANT
    // put under enemy bullet
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player") {
            SceneManager.LoadScene("Shooting Game");
        }
        else if (other.tag == "Player Bullet"){
            gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
            gameObject.GetComponent<SpriteRenderer>().color = Color.green;
            gameObject.tag = "Player Bullet";
        }
        else {
            Destroy(gameObject);
        }
    }
}
