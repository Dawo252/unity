using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_10 : MonoBehaviour
{
    float forward = 0.02f;
    float counter = 0.0f;

    void Start()
    {
    }

    void FixedUpdate()
    {
        transform.position += new Vector3(forward, 0, 0);
        counter += forward;
        if(counter > 10.1f){
            forward = -0.02f;
        }
        else if(counter < -0.1f){
            forward = 0.02f;
        }

    }
}
