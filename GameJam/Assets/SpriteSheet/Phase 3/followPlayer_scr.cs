using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer_scr : MonoBehaviour
{
	[SerializeField] GameObject Player;
	[SerializeField] GameObject StartPos;
	[SerializeField] GameObject EndPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Player.transform.position.x >= StartPos.transform.position.x + 3.5 && Player.transform.position.x <= EndPos.transform.position.x - 9.5)
		{
			if (Player.transform.position.x < transform.position.x - 6)
			{
				Vector3 pos = transform.position;
				pos.x = Player.transform.position.x + 6;
				transform.position = pos;
			}
			if (Player.transform.position.x > transform.position.x)
			{
				Vector3 pos = transform.position;
				pos.x = Player.transform.position.x;
				transform.position = pos;
			}
		}
    }
}
