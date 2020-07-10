using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : EnemyController
{
    protected GameObject target;

    // Update is called once per frame
    override protected void Update()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        if (target != null)
        {
            if (target.transform.position.x < endPoint && target.transform.position.x > startPoint)
            {
                chase();
            }
            else
            {
                obj.idle();
            }
        }
        else
        {
            obj.idle();
        }
        
    }
    protected void chase()
    {
        if (target.transform.position.x > transform.position.x)
        {
            obj.moveRight();
        }
        else
        {
            obj.moveLeft();
        }
    }
}
