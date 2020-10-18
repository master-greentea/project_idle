using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDying : MonoBehaviour
{
    GameObject cam;
    void Start()
    {
        cam = GameObject.Find("Main Camera");
    }
    // IMPORTANT
    // put under enemy bullet
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player") {
            cam.GetComponent<AudioSource>().Play(); 
            Destroy(GameObject.Find("Shooter Player"));
        }
        else if (other.tag == "Player Bullet"){
            gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
            gameObject.GetComponent<SpriteRenderer>().color = Color.green;
            gameObject.tag = "Player Bullet";
            GetComponent<AudioSource>().Play();
        }
        else {
            Destroy(gameObject);
        }
    }
}
