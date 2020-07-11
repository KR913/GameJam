using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class PlayerData_scr
{
    // Start is called before the first frame update
    public int health;
    public int level;

    public PlayerData_scr(Health_scr player)
    {
        health = player.Health;
        level = 0;
    }
    public PlayerData_scr(Health_scr player,int lv)
    {
        health = player.Health;
        level = lv;
    }
}
