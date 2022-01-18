using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D body;
    private float speed = 5;

    // Start is called before the first frame update
    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        PlayerMove();
        PlayerJump();
    }

    private void PlayerMove()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float movingSpeed = x * speed;
        body.velocity = new Vector2(movingSpeed, body.velocity.y);
    }

    private void PlayerJump()
    {
        if(Input.GetKey("space"))
        {
            body.velocity = new Vector2(0, 6f);
        }
    }
}
