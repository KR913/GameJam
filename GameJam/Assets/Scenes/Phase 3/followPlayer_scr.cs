using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer_scr : MonoBehaviour
{
	[SerializeField] GameObject Player;
	[SerializeField] GameObject StartPos;
	[SerializeField] GameObject EndPos;
	float range;
    // Start is called before the first frame update
    void Start()
    {
		range = transform.position.x - StartPos.transform.position.x - 0.5f;
	}

    // Update is called once per frame
    void Update()
    {
		if (Player.transform.position.x >= StartPos.transform.position.x + .5f + range / 3 && Player.transform.position.x <= EndPos.transform.position.x - .5f- range)
		{
			if (Player.transform.position.x < transform.position.x - 2*range/3)
			{
				Vector3 pos = transform.position;
				pos.x = Player.transform.position.x + 2 * range / 3;
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
