using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickPortal : MonoBehaviour
{
    // Start is called before the first frame update
    public string sceneToGo;
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        SceneManager.LoadScene(sceneToGo);
    }
}
