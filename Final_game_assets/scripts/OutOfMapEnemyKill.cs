using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfMapEnemyKill : MonoBehaviour
{
    
    public Transform target;
    public Vector3 offset = new Vector3(0, 0, -10);

    void FixedUpdate ()
    {
        Vector3 desiredPosition = target.position + offset;
        transform.position = desiredPosition;
        
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            Destroy(other.gameObject);
        }
    }
}
