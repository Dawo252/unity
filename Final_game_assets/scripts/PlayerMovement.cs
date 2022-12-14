using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    private Rigidbody2D _player;

    public float moveHorizontal;

    public float moveVertical;

    // Start is called before the first frame update
    void Start()
    {
        _player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
        _player.velocity = new Vector2(moveHorizontal * speed * Time.deltaTime, moveVertical * speed * Time.deltaTime);
        Vector3 newRotation = new Vector3(0, 180, 0);
        Vector3 newRotation2 = new Vector3(0, 0, 0);
        if (Input.GetKey("a"))
        {
            _player.gameObject.transform.eulerAngles = newRotation;
        }
        if (Input.GetKey("d"))
        {
            _player.gameObject.transform.eulerAngles = newRotation2;
        }
    }
    
}
