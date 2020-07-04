using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody2D))]

public class ObjectMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float jumpForce = 5f;
    Rigidbody2D rb;
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
        anim.SetBool("isRunning", true);
        turnLeft();
        rb.transform.Translate(new Vector3(moveSpeed * Time.deltaTime, 0, 0));
        //rb.AddForce(Vector2.right*moveSpeed);
    }

    public void moveLeft(Animator anim)
    {
        anim.SetBool("isRunning", true);
        turnRight();
        rb.transform.Translate(new Vector3(-moveSpeed * Time.deltaTime, 0, 0));
        //rb.AddForce(move, 0);
    }

    public void moveUp(Animator anim)
    {
        if (allowJump == true)
        {
            anim.SetBool("isJumping", true);
            anim.SetBool("isRunning", false);
            rb.transform.Translate(new Vector3(0, jumpForce * Time.deltaTime, 0));
            //rb.AddForce(Vector2.up * jumpForce);
        }
    }

    public void idle(Animator anim)
    {
        anim.SetBool("isRunning", false);
        anim.SetBool("isJumping", false);
    }

    public void turnRight()
    {
        transform.localScale = new Vector2(1, 1);
    }

    public void turnLeft()
    {
        transform.localScale = new Vector2(-1, 1);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground" || collision.gameObject.tag == "planet")
            allowJump = true;
        else
            allowJump = false;
    }
}
