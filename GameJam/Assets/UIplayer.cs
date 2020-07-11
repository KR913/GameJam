using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIplayer : MonoBehaviour
{
    Text text;
    void Start()
    {
        text = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        int hp=0 ;
        if (player != null)
        {
            hp = player.GetComponent<Health_scr>().Health;
        }
        text.text = "LIVES: "+hp.ToString();
    }
}
