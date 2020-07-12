using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_scr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        reset();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void reset()
    {
        SaveSystem.Reset();
    }

}
