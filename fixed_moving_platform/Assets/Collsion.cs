using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collsion : MonoBehaviour
{
    public GameObject platform;
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player1"))
        {
            other.transform.parent = platform.transform;
        }
    }
}
