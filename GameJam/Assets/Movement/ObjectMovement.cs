﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody2D))]

public class ObjectMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float jumpForce;
    Rigidbody2D rb;
    Vector2 moveHorizontal, moveVertical;
    bool allowJump = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void moveRight(Animator anim)
    {
        moveHorizontal = new Vector2(-transform.localScale.x * moveSpeed, 0);

        anim.SetBool("isRunning", true);
        turnRight();
        //rb.transform.Translate(new Vector3(moveSpeed * Time.deltaTime, 0, 0));
        rb.AddForce(moveHorizontal);
    }

    public void moveLeft(Animator anim)
    {
        moveHorizontal = new Vector2(-transform.localScale.x * moveSpeed, 0);

        anim.SetBool("isRunning", true);
        turnLeft();
        //rb.transform.Translate(new Vector3(-moveSpeed * Time.deltaTime, 0, 0));
        rb.AddForce(moveHorizontal);
    }

    public void moveUp(Animator anim)
    {
        if (allowJump == true)
        {
            moveVertical = new Vector2(0, transform.localScale.y * jumpForce);

            anim.SetBool("isJumping", true);
            anim.SetBool("isRunning", false);
            //rb.transform.Translate(new Vector3(0, jumpForce * Time.deltaTime, 0));
            rb.AddForce(moveVertical);
            allowJump = false;
        }
    }

    public void idle(Animator anim)
    {
        anim.SetBool("isRunning", false);
        anim.SetBool("isJumping", false);
    }

    public void turnRight()
    {
        transform.localScale = new Vector2(-1, 1);
    }

    public void turnLeft()
    {
        transform.localScale = new Vector2(1, 1);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground" || collision.gameObject.tag == "planet")
            allowJump = true;
    }
}
