using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveRight(Rigidbody2D rb, float moveSpeed)
    {
        rb.transform.Translate(new Vector3(moveSpeed * Time.deltaTime, 0, 0));
        transform.localScale = new Vector2(-1, 1);
    }

    public void moveLeft(Rigidbody2D rb, float moveSpeed)
    {
        rb.transform.Translate(new Vector3(-moveSpeed * Time.deltaTime, 0, 0));
        transform.localScale = new Vector2(1, 1);
    }

    public void moveUp(Rigidbody2D rb, float jumpForce)
    {
        rb.transform.Translate(new Vector3(0, jumpForce * Time.deltaTime, 0));
    }
    
}
