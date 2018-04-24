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
	private Animator anim;
    public bool canMove = true;
    public AudioSource jump;
    // Use this for initialization
    void Awake()
    {
        rb= GetComponent<Rigidbody2D>();
        velocity = new Vector2();
		anim = GetComponent<Animator> ();
    }

    private void Update()
    {
        if (!canMove)
        {
            return;
        }
        velocity.x = Input.GetAxis("Horizontal") * maxSpeed;
        velocity.y = 0;
		anim.SetFloat ("Run", velocity.x);

        if (Input.GetButtonDown("Jump"))
        {
            jump.Play();
            rb.velocity = new Vector2(rb.velocity.x, jumpTakeOffSpeed);
			anim.SetTrigger ("Jump");
        }
        
    }
    private void FixedUpdate()
    {
        rb.position += new Vector2(velocity.x, 0) * Time.deltaTime;
    }
}
