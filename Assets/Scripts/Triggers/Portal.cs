using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    // used for interaction & switching scens
    public string RoomToGo;

    // UI stuff
    public GameObject ui;
    public Sprite workstation;
    public Sprite gamestation;
    public Sprite guitarstation;
    void Start()
    {
        // initialize UI sprite as nothing
        ui.GetComponent<SpriteRenderer>().sprite = null;
    }

    void OnTriggerStay2D(Collider2D player) {
        // display UI text
        if (RoomToGo == "Game") {
            ui.GetComponent<SpriteRenderer>().sprite = gamestation;
        }
        if (RoomToGo == "Work") {
            ui.GetComponent<SpriteRenderer>().sprite = workstation;
        }
        if (RoomToGo == "Guitar") {
            ui.GetComponent<SpriteRenderer>().sprite = guitarstation;
        }
        
        if (Input.GetKey(KeyCode.F)) {
            SceneManager.LoadSceneAsync(RoomToGo);
        }
    }

    void OnTriggerExit2D(Collider2D player) {
        // reset UI sprite to nothing
        ui.GetComponent<SpriteRenderer>().sprite = null;
    }
}
