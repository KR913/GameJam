using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation_scr : MonoBehaviour
{
	[SerializeField] Vector3 RSpeed; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		transform.Rotate(RSpeed);
    }
	
}
