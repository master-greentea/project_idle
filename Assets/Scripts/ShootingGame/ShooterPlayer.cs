using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShooterPlayer : MonoBehaviour
{
    float inputHori;
    float inputVerti;
    Rigidbody2D myRb;
    public float moveSpeed = 10f;
    public Rigidbody2D playerBullet;
    public float shootForce = 250f;
    void Start()
    {
        myRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // player movements on both axises
        inputHori = Input.GetAxis("Horizontal");
        inputVerti = Input.GetAxis("Vertical");

        // mouse pointing
        Vector3 mouseCursorPosInWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 fromPlayerToMouse = mouseCursorPosInWorld - transform.position;

        // rotate to align right with vector towards mouse
        transform.right = fromPlayerToMouse;
        // visualizing
        Debug.DrawRay(transform.position, fromPlayerToMouse, Color.green);

        // fire raycast from player to mouse
        Ray2D myRay = new Ray2D(transform.position, transform.right);
        float myRayDistance = 10f;
        RaycastHit2D myRayHit = Physics2D.Raycast(myRay.origin, myRay.direction, myRayDistance);

        // player shooting
        if (Input.GetMouseButtonDown(0)) {
            Rigidbody2D newClone = Instantiate(playerBullet, transform.position + transform.right, gameObject.transform.rotation);
            // adding force to "down"
            newClone.AddForce(transform.right * shootForce);
        }

        // check to see if won
        if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0) {
            SceneManager.LoadScene("Game");
        }
    }

    void FixedUpdate() {
        // adding velocity to player (moving)
        myRb.velocity = new Vector2(inputHori * moveSpeed, inputVerti * moveSpeed);
    }
}
