﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] GameObject shooter;
    [SerializeField] float movementSpeed = 4f;
    [SerializeField] float range = 4f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, range);   
    }

    // Update is called once per frame
    void Update()
    {
        Bullet_Movement(movementSpeed);
    }
    public void Bullet_Movement(float movementspeed)
    {
        gameObject.transform.Translate(new Vector3(-movementSpeed*Mathf.Sign(gameObject.transform.localScale.x) * Time.deltaTime, 0, 0));
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        Destroy(gameObject, Time.deltaTime);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Destroy(gameObject, Time.deltaTime);
    }
}
