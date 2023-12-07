using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isPlayer;
    public float jumpAmount = 10;
    public float speedHorizontal;
    public float speedVertical;
    public Rigidbody2D rb;
    private float movementHorizontal;

    // Update is called once per frame
    void Update()
    {
        if (isPlayer)
        {
            movementHorizontal = Input.GetAxisRaw("Horizontal");

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
        }
        // rb.velocity = new Vector2(rb.velocity.y, movementVertical * speedVertical);
        rb.velocity = new Vector2(movementHorizontal * speedHorizontal, rb.velocity.y);
    }
}