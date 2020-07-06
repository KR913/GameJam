using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_scr : MonoBehaviour
{
    public int Health = 5;
    bool hitable = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Hitable_LoadingTime()
    {
        hitable = false;
        yield return new WaitForSeconds(2);
        hitable = true;
    }

    public void Damage()
    {
        if (hitable && Health>0)
        {
            --Health; Debug.Log("RIPPPPPPPPPPPPPP     "+ Health);
            StartCoroutine(Hitable_LoadingTime());
        }
    }
}
