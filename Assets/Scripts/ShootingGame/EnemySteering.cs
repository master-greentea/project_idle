using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySteering : MonoBehaviour
{
    PolygonCollider2D player;
    BoxCollider2D playerGun;
    
    void Start()
    {
        player = GameObject.Find("Shooter Player").GetComponent<PolygonCollider2D>();
        playerGun = GameObject.Find("Gun").GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        // moves right
        transform.Translate(2f * Time.deltaTime, 0f, 0f);

        // setting up ray
        Ray2D myRay = new Ray2D(transform.position, transform.right);
        float myRayDistance = 1f;
        Debug.DrawRay(myRay.origin, myRay.direction * myRayDistance, Color.blue);

        // firing raycast
        RaycastHit2D myRayHit = Physics2D.Raycast(myRay.origin, myRay.direction, myRayDistance);

        // ray checking
        if (myRayHit.collider != null && myRayHit.collider != player && myRayHit.collider != playerGun) {
            float randNo = Random.Range(0, 100);
            if (randNo < 50) {
                transform.Rotate(0, 0, 90f);
            }
            else {
                transform.Rotate(0, 0, -90f);
            }
        }
    }
}
