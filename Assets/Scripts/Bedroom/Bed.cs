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
    }

    void OnTriggerStay2D(Collider2D activator)
    {
        if (Input.GetKey(KeyCode.F)) {
            spriteChange();
        }
    }
    
    void OnTriggerExit2D()
    {
        currentSprite = outside.sprite;
    }
}
