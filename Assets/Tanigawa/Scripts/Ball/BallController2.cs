using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController2 : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(Vector2.left * speed, ForceMode2D.Force);
    }
}

