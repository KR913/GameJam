using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoFall_scr : MonoBehaviour
{
	[SerializeField] GameObject meteo;
    // Start is called before the first frame update
    void Start()
    {
		StartCoroutine(generate());
	}

    // Update is called once per frame
    void Update()
    {
		
	}

	IEnumerator generate()
	{
		while (true)
		{
			yield return new WaitForSeconds(Random.Range(0.3f,1.2f));
			Instantiate(meteo, new Vector3(Random.Range(-7.5f + transform.position.x, 14f + transform.position.x), 5.5f, 0), Quaternion.identity);
		}
	}
}
