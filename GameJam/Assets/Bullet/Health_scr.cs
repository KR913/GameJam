using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_scr : MonoBehaviour
{
    public int Health = 5;
    bool hitable = true;
    [SerializeField] bool Player = false;
    [SerializeField] GameObject heart;
    // Start is called before the first frame update
    void Start()
    {
        if (Player)
        {
            PlayerData_scr PD = SaveSystem.LoadLayer();
            if (PD == null)
            {
                Health = 10;
            }
            else
            {
                Health = PD.health;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Health == 0)
        {
            Die();
        }

    }
    IEnumerator Hitable_LoadingTime()
    {
        hitable = false;
        yield return new WaitForSeconds(1);
        hitable = true;
    }
    IEnumerator hitstate()
    {
        SpriteRenderer spr = gameObject.GetComponent<SpriteRenderer>();
        if (spr.color.a > 0)
        {
            float d = spr.color.r;
            Color c = new Color(d, d, d, 0);
            spr.color = c;
        }
        else
        {
            float d = spr.color.r;
            Color c = new Color(d, d, d, 1);
            spr.color = c;
        }
        yield return new WaitForSeconds(.15f);
        if (hitable)
        {
            float d = spr.color.r;
            Color c = new Color(d, d, d, 1);
            spr.color = c;
        }
        else
        {
            StartCoroutine(hitstate());
        }
    }
    public void Damage()
    {
        if (hitable && Health>0)
        {
            --Health;
            if (Health > 0)
                StartCoroutine(hitstate());
            StartCoroutine(Hitable_LoadingTime());
        }
    }
    void Die()
    {
        ObjectMovement om = gameObject.GetComponent<ObjectMovement>();
        Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
        if (om != null)
        {
            om.pause = true;
        }
        if (rb != null)
        {
            rb.isKinematic = false;
        }
        SpriteRenderer spr = gameObject.GetComponent<SpriteRenderer>();
        if (spr.color.r > 0)
        {
            float d = spr.color.r - .01f;
            Color c = new Color(d,d,d);
            spr.color = c;
        }
        else
        {
            if (heart != null)
            {
                Destroy(heart,3);
            }
        }
    }
}
