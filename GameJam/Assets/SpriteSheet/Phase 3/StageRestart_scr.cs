using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageRestart_scr : MonoBehaviour
{
	// Start is called before the first frame update
	Collider2D PlayerBox;
	[SerializeField]GameObject Player;
    void Start()
    {
		PlayerBox = Player.GetComponent(typeof(Collider2D)) as Collider2D;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerBox.IsTouching(gameObject.GetComponent(typeof(Collider2D)) as Collider2D))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
    }
}
