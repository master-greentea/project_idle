using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSpawn : MonoBehaviour
{
    float x;
    public GameObject cat;
    // on first entering bedroom, maybe spawn cat
    void Start()
    {
        x = Random.Range(0f, 100f);
        // a 25 percent chance to spawn cat
        if (x >= 75) {
            cat.SetActive(true);
        }
    }
}
