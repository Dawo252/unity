using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public GameObject[] waypoints;
    private int currentWaypointInd = 0;
    public float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, waypoints[currentWaypointInd].transform.position) < .1f)
        {
            currentWaypointInd++;
            if (currentWaypointInd >= waypoints.Length)
            {
                currentWaypointInd = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointInd].transform.position,
            speed * Time.deltaTime);
    }
}
