using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraLimits : MonoBehaviour
{
    CinemachineVirtualCamera cam;
    Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
        cam = GameObject.Find("CM vcam1").GetComponent<CinemachineVirtualCamera>();
    }

    void OnTriggerEnter2D(Collider2D activator) {
        cam.m_Follow = null;
    }

    void OnTriggerExit2D(Collider2D activator) {
        cam.m_Follow = player;
    }
}
