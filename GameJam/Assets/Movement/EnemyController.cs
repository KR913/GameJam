using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] float distance;
    bool moveRight = true;
    float startPoint;
    float endPoint;

    Rigidbody2D rbEnemy;
    ObjectMovement obj;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        startPoint = rbEnemy.transform.position.x - distance;
        endPoint = rbEnemy.transform.position.x + distance;
        anim = gameObject.GetComponent<Animator>();
        obj = gameObject.GetComponent<ObjectMovement>();
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
            //obj.moveRight(anim);
        }
        else
        {
            anim.SetBool("isRunningEnemy", true);
            //obj.moveLeft(anim);
        }
    }
}
