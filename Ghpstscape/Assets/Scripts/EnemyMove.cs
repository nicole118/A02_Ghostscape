using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : GameData
{
    private Rigidbody2D rb;
    private Vector2 movement;
    private float moveSpeed = 3f;

   
    // Start is called before the first frame update
    protected override void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        MoveEnemy();
    }

    private void FixedUpdate()
    {
        MoveCharacter(movement);
    }

    private void MoveEnemy()
    {
        Vector3 direction = player.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x);
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;

    }

    private void MoveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
}
