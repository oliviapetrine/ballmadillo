using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armadilloMovement : MonoBehaviour
{
    
    public Vector3 velocityForwardBackward;
    public Vector3 velocityLeftRight;

    public KeyCode keyForward;
    public KeyCode keyBackward;
    public KeyCode keyLeft;
    public KeyCode keyRight;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(keyForward))
        {
            GetComponent<Rigidbody>().velocity += velocityForwardBackward;
        }
        if (Input.GetKey(keyBackward))
        {
            GetComponent<Rigidbody>().velocity -= velocityForwardBackward;
        }
        if (Input.GetKey(keyLeft))
        {
            GetComponent<Rigidbody>().velocity += velocityLeftRight;
        }
        if (Input.GetKey(keyRight))
        {
            GetComponent<Rigidbody>().velocity -= velocityLeftRight;
        }

    }


}
