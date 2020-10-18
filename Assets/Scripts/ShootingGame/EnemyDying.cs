using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDying : MonoBehaviour
{
    GameObject cam;
    void Start()
    {
        cam = GameObject.Find("Main Camera");
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        cam.GetComponent<AudioSource>().Play();  
        if (other.tag == "Player Bullet") {         
            Destroy(other.gameObject);
            Destroy(gameObject);
        }  
        Debug.Log("Hit");

        if (other.tag == "Player") {
            Destroy(GameObject.Find("Shooter Player"));
        }
    }
}
