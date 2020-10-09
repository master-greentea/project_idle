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
            SceneManager.LoadSceneAsync(RoomToGo);
        }
    }
}
