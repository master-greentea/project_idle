using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : MonoBehaviour
{
    // put in bed, sleep to change day and night
    SpriteRenderer outside;
    public Sprite daySprite;
    public Sprite nightSprite;
    Sprite currentSprite;

    public GameObject ui;
    public Sprite sleepstation;
    public Sprite slept;
    bool sleptCheck = false;
    void Start()
    {
        outside = GameObject.Find("Outside").GetComponent<SpriteRenderer>();
        currentSprite = outside.sprite;
    }

    void spriteChange()
    {
        if (currentSprite == daySprite) {
            outside.sprite = nightSprite;
        }
        else if (currentSprite == nightSprite) {
            outside.sprite = daySprite;
        }
        sleptCheck = true;
    }

    void OnTriggerStay2D(Collider2D activator)
    {
        if (!sleptCheck) {
            ui.GetComponent<SpriteRenderer>().sprite = sleepstation;
        }
        else {
            ui.GetComponent<SpriteRenderer>().sprite = slept;
        }
        if (Input.GetKey(KeyCode.F)) {
            spriteChange();
        }
    }
    
    void OnTriggerExit2D()
    {
        sleptCheck = false;
        ui.GetComponent<SpriteRenderer>().sprite = null;
        currentSprite = outside.sprite;
    }
}
