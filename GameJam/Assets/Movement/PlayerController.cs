using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(ObjectMovement))]

public class PlayerController : MonoBehaviour
{
    //Animator anim;
    ObjectMovement obj;
    BulletShoot bs;
    
    // Start is called before the first frame update
    void Start()
    {
        //anim = gameObject.GetComponent<Animator>();
        obj = gameObject.GetComponent<ObjectMovement>();
        bs = gameObject.GetComponent<BulletShoot>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A) || Input.GetKeyDown(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.D))
            {
                obj.moveRight();
            }
            if (Input.GetKey(KeyCode.A))
            {
                obj.moveLeft();
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                obj.moveUp();
            }
        }
        else
        {
            obj.idle();
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            bs.Fire();
        }
    }
}
