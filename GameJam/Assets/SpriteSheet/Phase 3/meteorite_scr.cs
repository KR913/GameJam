using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorite_scr : MonoBehaviour
{
	// Start is called before the first frame update
	[SerializeField] Vector3 MSpeed;
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		transform.position += MSpeed;
    }
}
