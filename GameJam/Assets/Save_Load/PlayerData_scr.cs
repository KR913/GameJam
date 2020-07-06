using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
