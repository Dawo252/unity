using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Update()
    {

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        player.transform.position += new Vector3(h * Time.deltaTime * 5,
            0, v * Time.deltaTime * 5);
    }
}
