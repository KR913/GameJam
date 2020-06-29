using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rbPlayer;
    public float moveSpeed = 5f;
    public float jumpForce = 3f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rbPlayer.velocity = new Vector2(moveSpeed * Input.GetAxis("Horizontal"), rbPlayer.velocity.y);
            transform.localScale = new Vector2(-1, 1);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rbPlayer.velocity = new Vector2(moveSpeed * Input.GetAxis("Horizontal"), rbPlayer.velocity.y);
            transform.localScale = new Vector2(1, 1);
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            rbPlayer.velocity = new Vector2(rbPlayer.velocity.x, moveSpeed * Input.GetAxis("Vertical"));
        }
    }
}
