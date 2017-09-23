using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    private Rigidbody2D rigidbody2d;
    public float maxSpeed = 10f;

    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void Start()
    {

    }

    private void FixedUpdate()
    {
        float move = -0.1f;
        rigidbody2d.velocity = new Vector2(move * maxSpeed, rigidbody2d.velocity.y);
        this.gameObject.transform.rotation = Quaternion.Euler(0, this.gameObject.transform.rotation.y, 0);
    }
}
