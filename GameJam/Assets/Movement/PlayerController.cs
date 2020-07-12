using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(ObjectMovement))]

public class PlayerController : MonoBehaviour
{
    //Animator anim;
    ObjectMovement obj;
    BulletShoot bs;
    KeyCode up= KeyCode.W;
    KeyCode down= KeyCode.S;
    KeyCode left= KeyCode.A;
    KeyCode right= KeyCode.D;
    [SerializeField] int rotate = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        //anim = gameObject.GetComponent<Animator>();
        obj = gameObject.GetComponent<ObjectMovement>();
        bs = gameObject.GetComponent<BulletShoot>();
        while (rotate > 0)
        {
            KeyCode temp = up;
            up = right;
            right = down;
            down = left;
            left = temp;
            rotate--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(right) || Input.GetKey(left) || Input.GetKeyDown(up))
        {
            if (Input.GetKey(right))
            {
                obj.moveRight();
            }
            if (Input.GetKey(left))
            {
                obj.moveLeft();
            }
            if (Input.GetKeyDown(up))
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
