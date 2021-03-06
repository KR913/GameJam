﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase_Shoot : EnemyChase
{
    [SerializeField] float Avoid;
    [SerializeField] float Range;
    BulletShoot bs;
    // Start is called before the first frame update
    void Start()
    {
		startPoint = transform.position.x - distance;
		endPoint = transform.position.x + distance;
		obj = gameObject.GetComponent<ObjectMovement>();
        bs = gameObject.GetComponent<BulletShoot>();
    }

    // Update is called once per frame
    override protected void Update()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        if (target != null)
        {
            if (target.transform.position.x < endPoint && target.transform.position.x > startPoint)
            {
                if (Mathf.Abs(target.transform.position.x - transform.position.x) > Avoid)
                {
                    chase();
                }
                else
                {
                    if ((target.transform.position.x - transform.position.x) * transform.localScale.x > 0)
                    {
                        chase();
                    }
                    else
                    {
                        obj.idle();
                    }
                }
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
        if (Mathf.Abs(target.transform.position.x - transform.position.x) < Range)
        {
            bs.Fire();
        }
    }
}
