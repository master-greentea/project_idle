using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFiring : MonoBehaviour
{
    public float shootForce = 900f;
    public Rigidbody2D enemyBullet;
    PolygonCollider2D player;
    BoxCollider2D playerGun;
    
    void Start()
    {
        player = GameObject.Find("Shooter Player").GetComponent<PolygonCollider2D>();
        playerGun = GameObject.Find("Gun").GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray2D myRay = new Ray2D(transform.position, transform.right);
        float myRayDistance = 15f;
        Debug.DrawRay(myRay.origin, myRay.direction * myRayDistance, Color.red);
        RaycastHit2D myRayHit = Physics2D.Raycast(myRay.origin, myRay.direction, myRayDistance);
        if (myRayHit.collider == player || myRayHit.collider == playerGun) {
            Rigidbody2D newClone = Instantiate(enemyBullet, transform.position + transform.right, gameObject.transform.rotation);
            // adding force to "down"
            newClone.AddForce(transform.right * shootForce);
            GetComponent<AudioSource>().Play();
        }

    }
}
