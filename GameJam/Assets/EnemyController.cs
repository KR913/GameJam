using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed;
    public float distance;
    public Rigidbody2D rbEnemy;

    bool moveRight = true;
    float startPoint;
    float endPoint;
    [SerializeField] ObjectMovement obj;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        startPoint = rbEnemy.transform.position.x - distance;
        endPoint = rbEnemy.transform.position.x + distance;
        //Debug.Log(startPoint);
        //Debug.Log(endPoint);
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rbEnemy.transform.position.x >= endPoint || rbEnemy.transform.position.x <= startPoint)
        {
            if (moveRight == true)
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
            anim.SetBool("isRunningEnemy", true);
            obj.moveRight(rbEnemy, moveSpeed);
        }
        else
        {
            anim.SetBool("isRunningEnemy", true);
            obj.moveLeft(rbEnemy, moveSpeed);
        }
    }
}
