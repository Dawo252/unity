using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_10_around : MonoBehaviour
{
    float forward = 0.02f;
    int counter = 0;

    void Start()
    {
    }

    void FixedUpdate()
    {
    	counter = counter + 1;
        if(counter <= 500){
        	transform.position += new Vector3(forward, 0, 0);
        	if(counter == 500){
        		transform.Rotate(0, -90.0f, 0, Space.Self);
        	}
        }
      	else if(counter > 500 & counter <= 1000){
            	transform.position += new Vector3(0, 0, forward);
        	if(counter == 1000){
        		transform.Rotate(0, -90.0f, 0, Space.Self);
        	}
        }
	else if(counter > 1000 & counter <= 1500){
            	transform.position += new Vector3(-forward, 0, 0);
        	if(counter == 1500){
        		transform.Rotate(0, -90.0f, 0, Space.Self);
        	}
        }
        else if(counter > 1500 & counter <= 2000){
        	transform.position += new Vector3(0, 0, -forward);
		if(counter == 2000){
			transform.Rotate(0, -90.0f, 0, Space.Self);
			counter = 0;
		}
	}
    }
}
