using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rbPlayer;
    Animator anim;
    [SerializeField] ObjectMovement obj;
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.D))
            {
                anim.SetBool("isRunning", true);
                obj.moveRight(rbPlayer, moveSpeed);
                //transform.localScale = new Vector2(-1, 1);
            }
            if (Input.GetKey(KeyCode.A))
            {
                anim.SetBool("isRunning", true);
                obj.moveLeft(rbPlayer, moveSpeed);
                //transform.localScale = new Vector2(1, 1);
            }
            if (Input.GetKey(KeyCode.W))
            {
                anim.SetBool("isJumping", true);
                anim.SetBool("isRunning", false);
                obj.moveUp(rbPlayer, jumpForce);
            }
        }
        else
        {
            anim.SetBool("isRunning", false);
            anim.SetBool("isJumping", false);
        }
    }
}
