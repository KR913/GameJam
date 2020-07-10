using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] float distance;
    bool moveRight = true;
    protected float startPoint;
    protected float endPoint;
    
    protected ObjectMovement obj;

    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject.GetComponent<ObjectMovement>();

        startPoint = transform.position.x - distance;
        endPoint = transform.position.x + distance;
        
    }

    // Update is called once per frame
    virtual protected void Update()
    {
        if (transform.position.x > endPoint || transform.position.x < startPoint)
        {
            if (transform.position.x > endPoint)
            {
                moveRight = false;
            }
            else
            {
                moveRight = true;
            }
        }
        if (moveRight == true)
        {
            //anim.SetBool("isRunning", true);
            obj.moveRight();
        }
        else
        {
            //anim.SetBool("isRunning", true);
            obj.moveLeft();
        }
    }
}
