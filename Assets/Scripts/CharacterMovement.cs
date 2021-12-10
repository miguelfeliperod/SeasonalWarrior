using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    public const float MAX_SPEED = 6f;
    public Rigidbody2D rb;
    public Collider2D characterCollider;

    public float xAcceleration;
    public float yAcceleration;
    private Vector2 characterSpeed = Vector2.zero;
    private Vector2 jumpSpeed = Vector2.zero;

    void Awake() {
         jumpSpeed = new Vector2(0, yAcceleration);
    }
        
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) {
            rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x + xAcceleration, 0, MAX_SPEED), rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x - xAcceleration, -MAX_SPEED, 0), rb.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
            rb.AddForce(jumpSpeed);
    }
}
