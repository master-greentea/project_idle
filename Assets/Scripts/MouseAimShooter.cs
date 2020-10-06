using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAimShooter : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
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


    }
}
