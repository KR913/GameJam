using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(ObjectMovement))]

public class PlayerController : MonoBehaviour
{
    Animator anim;
    ObjectMovement obj;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        obj = gameObject.GetComponent<ObjectMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.D))
            {
                obj.moveRight(anim);
            }
            if (Input.GetKey(KeyCode.A))
            {
                obj.moveLeft(anim);
            }
            if (Input.GetKey(KeyCode.W))
            {
                obj.moveUp(anim);
            }
        }
        else
        {
            obj.idle(anim);
        }
    }
}
