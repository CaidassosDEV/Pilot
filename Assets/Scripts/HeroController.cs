using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{

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
        VerticalHeroMovement();
    }

    private void HorizontalHeroMovement(float move)
    {
        animator.SetFloat("speed", Mathf.Abs(move));

        rigidbody2d.velocity = new Vector2(move * maxSpeed, rigidbody2d.velocity.y); // TODO: Use AddForce
        this.gameObject.transform.rotation = Quaternion.Euler(0, this.gameObject.transform.rotation.y, 0);

        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();
    }

    private void VerticalHeroMovement()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2d.AddForce(new Vector2(0, 3000f));
        }
        if (transform.position.y >= 10)
            rigidbody2d.velocity = Vector2.zero;
    }

    private void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
