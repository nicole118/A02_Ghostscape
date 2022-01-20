using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D body;
    private BoxCollider2D collide;
    [SerializeField] private LayerMask JumpableGround;
    private float speed = 5;

    // Start is called before the first frame update
    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
        collide = GetComponent<BoxCollider2D>();
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
        if(Input.GetKey("space") && (isGrounded()))
        {
            body.velocity = new Vector2(0, 9f);
        }
    }

    private bool isGrounded()
    {
        return Physics2D.BoxCast(collide.bounds.center, collide.bounds.size, 0f, Vector2.down, .1f, JumpableGround);

    }
}
