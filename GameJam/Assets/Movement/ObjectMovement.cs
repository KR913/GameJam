using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody2D))]

public class ObjectMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float accel;
    [SerializeField] float jumpForce;
    [SerializeField] float size = 1;
    Rigidbody2D rb;
    Animator anim;
    Vector2 moveHorizontal, moveVertical;
    bool allowJump = false;
    public bool pause = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pause)
        {
            anim.SetBool("isRunning", false);
            anim.SetBool("isJumping", false);
        }
        anim.SetBool("isJumping", !allowJump);
    }

    public void moveRight()
    {
        if (!pause)
        {
            if (rb.velocity.x < moveSpeed/2)
            {
                rb.velocity = new Vector2(moveSpeed / 2, rb.velocity.y);
            }
            if (rb.velocity.x < moveSpeed)
            {
                moveHorizontal = new Vector2(-transform.localScale.x * accel, 0);

                anim.SetBool("isRunning", true);
                turnRight();
                rb.AddForce(moveHorizontal);
            }
        }
    }

    public void moveLeft()
    {
        if (!pause)
        {
            if (rb.velocity.x > -moveSpeed / 2)
            {
                rb.velocity = new Vector2(-moveSpeed / 2, rb.velocity.y);
            }
            if (rb.velocity.x > -moveSpeed)
            {
                moveHorizontal = new Vector2(-transform.localScale.x * accel, 0);

                anim.SetBool("isRunning", true);
                turnLeft();
                rb.AddForce(moveHorizontal);
            }
        }
    }

    public void moveUp()
    {
        if (!pause)
        {
            if (allowJump == true)
            {
                moveVertical = new Vector2(0, transform.localScale.y * jumpForce);

                anim.SetBool("isJumping", true);
                anim.SetBool("isRunning", false);
                rb.AddForce(moveVertical);
            }
        }
    }

    public void idle()
    {
        if (!pause)
        {
            anim.SetBool("isRunning", false);
        }
        if (rb.velocity.x != 0 && allowJump)
        {
            rb.velocity -= new Vector2(rb.velocity.x / 2, 0);
        }
        else
        {
            rb.velocity -= new Vector2(rb.velocity.x *Time.deltaTime, 0);
        }
    }

    public void turnRight()
    {
        if (!pause)
        {
            transform.localScale = new Vector2(-1 * size, 1 * size);
        }
    }

    public void turnLeft()
    {
        if (!pause)
        {
            transform.localScale = new Vector2(1 * size, 1 * size);
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if(rb.IsTouchingLayers(LayerMask.GetMask("Ground")))
            allowJump = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        allowJump = false;
    }
}
