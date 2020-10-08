using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDying : MonoBehaviour
{
    void Start()
    {
        
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player Bullet") {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }  
        Debug.Log("Hit");

        if (other.tag == "Player") {
            SceneManager.LoadScene("Shooting Game");
        }
    }
}
