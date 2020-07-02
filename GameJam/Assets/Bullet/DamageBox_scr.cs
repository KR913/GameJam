using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBox_scr : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Health_scr hp = collision.collider.GetComponent<Health_scr>();
        if(hp!= null)
        {
            hp.Damage();
           
        }
    }
}
