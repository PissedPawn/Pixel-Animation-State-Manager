using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerMovementManager : MonoBehaviour, IMovementManager
{
    public IInputManager inputManager { get; set; }
    public Rigidbody2D rb { get; set; }

    public bool isFacingRight { get; set; }

    public float jumpForce { get; set; } = 10;

    public float speed { get; set; } = 15;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        inputManager = GetComponent<PlatformerInputManager>();

    }

    void Update()
    {
        CheckFaceDirection();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();

        if(inputManager.jump)
        {
            Jump();
        }
    }

    void CheckFaceDirection()
    {
        if (isFacingRight && inputManager.x > 0)
            Flip();
        else if (!isFacingRight && inputManager.x < 0)
            Flip();
    }

    void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.Rotate(0, 180, 0);
    }

    void Move()
    {
        rb.velocity = new Vector2(inputManager.x * speed, rb.velocity.y);
    }

    void Jump()
    {
        rb.velocity= new Vector2(rb.velocity.x, jumpForce);
    }
}
