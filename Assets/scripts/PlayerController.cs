using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float maxSpeed = 7;
    public float jumpTakeOffSpeed = 7;
    public float gravityEffect;
    public Vector2 velocity;
    private Rigidbody2D rb;
    public bool canMove = true;
    // Use this for initialization
    void Awake()
    {
        rb= GetComponent<Rigidbody2D>();
        velocity = new Vector2();
    }

    private void Update()
    {
        if (!canMove)
        {
            return;
        }
        velocity.x = Input.GetAxis("Horizontal") * maxSpeed;
        velocity.y = 0;
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpTakeOffSpeed);
        }
        
    }
    private void FixedUpdate()
    {
        rb.position += new Vector2(velocity.x, 0) * Time.deltaTime;
    }
}
