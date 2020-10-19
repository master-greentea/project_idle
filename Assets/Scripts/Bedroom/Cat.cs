using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public GameObject ui;
    public Sprite catstation;
    public Sprite catted;
    bool catCheck = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D activator)
    {
        if (!catCheck) {
            ui.GetComponent<SpriteRenderer>().sprite = catstation;
        }
        else {
            ui.GetComponent<SpriteRenderer>().sprite = catted;
        }
        if (Input.GetKey(KeyCode.F)) {
            catCheck = true;
        }
    }

     void OnTriggerExit2D()
    {
        catCheck = false;
        ui.GetComponent<SpriteRenderer>().sprite = null;
    }
}
