using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] GameObject shooter;
    [SerializeField] float movementSpeed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5f);   
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
}
