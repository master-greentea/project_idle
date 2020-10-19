using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutDownEffect : MonoBehaviour
{
    // put under put down to have bubble effect
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time, .4f)-14.7f, -1.09f, -1);
    }
}
