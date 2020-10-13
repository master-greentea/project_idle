using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFront : MonoBehaviour
{
    public GameObject window;
    public bool forth;
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        if (forth) {
            window.transform.position = new Vector3(-7.54f, 3.57f, -15.6f);
        }
        else {
            window.transform.position = new Vector3(-7.54f, 3.57f, -1);
        }
    }
}
