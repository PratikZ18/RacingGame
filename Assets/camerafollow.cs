using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform target; // targetting our car

    public float SmoothSpeed = 0.125f; //following constant
    public Vector3 offset; // make the camera follow car from a fixed distance

    private Vector3 velocity = Vector3.zero;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate() //follow after car not with it
    {
        Vector3 DesiredPosition = target.position + offset; // the position we want to be at
        Vector3 SmoothenedPosition = Vector3.SmoothDamp(transform.position, DesiredPosition,ref velocity, SmoothSpeed); // linearly interpolates to desired position from current postion.
        transform.position = SmoothenedPosition; 

        transform.LookAt(target); //looks at the car continuosly.
    }
}
