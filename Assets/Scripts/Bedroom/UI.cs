using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    // put under UI
    public Transform player;
    void Start()
    {
        transform.position = player.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (player.position.x, -4.47f, -4.12f);
    }
}
