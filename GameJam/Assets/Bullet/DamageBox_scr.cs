using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBox_scr : MonoBehaviour
{
    private void OnCollisionStay2D(Collision2D collision)
    {
        Health_scr hp = collision.collider.GetComponent<Health_scr>();
        if(hp!= null)
        {
            hp.Damage();
           
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Health_scr hp = collision.gameObject.GetComponent<Health_scr>();
        if (hp != null)
        {
            hp.Damage();

        }
    }
}
