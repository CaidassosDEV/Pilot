using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    public float maxSpeed = 10f;
    private bool facingRight = true;
    private Rigidbody2D rigidbody2d;

    private Animator animator;

    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        HorizontalHeroMovement(Input.GetAxis("Horizontal"));
    }

    private void HorizontalHeroMovement(float move)
    {
        animator.SetFloat("speed", Mathf.Abs(move));

        rigidbody2d.velocity = new Vector2(move * maxSpeed, rigidbody2d.velocity.y);

        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();
    }

    private void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
