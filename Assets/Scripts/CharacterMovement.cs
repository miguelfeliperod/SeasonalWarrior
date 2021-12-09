using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    public const int MAX_SPEED = 5;
    public Rigidbody2D rb;
    public Collider2D characterCollider;

    public float xAcceleration;
    public float yAcceleration;
    private Vector2 characterSpeed = Vector2.zero;
    private Vector2 jumpSpeed = Vector2.zero;
    // Start is called before the first frame update
    void Awake()
    {
        characterSpeed.x = xAcceleration;
        jumpSpeed.y = yAcceleration;
    }

    // Update is called once per frame
    void Update()
    {
        characterSpeed.x = xAcceleration;
        jumpSpeed.y = yAcceleration;

        if(Input.GetKey(KeyCode.RightArrow)){
            rb.AddForce(characterSpeed);
            if(rb.velocity.x > MAX_SPEED)
                rb.velocity = new Vector2(MAX_SPEED, rb.velocity.y);
        } 
        if(Input.GetKey(KeyCode.LeftArrow)){
            rb.AddForce(-characterSpeed);
            if(rb.velocity.x < -MAX_SPEED)
                rb.velocity = new Vector2(-MAX_SPEED, rb.velocity.y);
        }
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            print("Jummped");
            rb.AddForce(jumpSpeed);
        }
    }
}
