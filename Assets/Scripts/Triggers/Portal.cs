using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public string RoomToGo;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerStay2D(Collider2D player) {
        if (Input.GetKey(KeyCode.F)) {
            if (RoomToGo == "Shooting Game") {
                float rand = Random.Range(0f, 100f);
                if (rand < 50) {
                    RoomToGo = "Platform Game";
                }
            }
            SceneManager.LoadSceneAsync(RoomToGo);
        }
    }
}
