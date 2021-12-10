using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    public const float MAX_SPEED = 6f;
    public Rigidbody2D rb;
    public Collider2D characterCollider;

    public float xAcceleration;
    public float yForce;
    private Vector2 jumpSpeed;

    private bool isGrounded = true;

    void Awake() {
         jumpSpeed = new Vector2(0, yForce);
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
        if (Input.GetKeyUp(KeyCode.UpArrow)){
            if(rb.velocity.y > 7)
            rb.velocity = new Vector2(rb.velocity.x, 7);
        }
    }
}
