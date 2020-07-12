using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SavePlayer (Health_scr player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath+"/playerHealth.savefile";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData_scr data = new PlayerData_scr(player);

        formatter.Serialize(stream, data);
        stream.Close();
    }
    public static void Reset()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/playerHealth.savefile";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData_scr data = new PlayerData_scr();

        formatter.Serialize(stream, data);
        stream.Close();
    }
    public static void SavePlayer(Health_scr player, int lv)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/playerHealth.savefile";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData_scr data = new PlayerData_scr(player,lv);

        formatter.Serialize(stream, data);
        stream.Close();
    }
    public static PlayerData_scr LoadLayer()
    {
        string path = Application.persistentDataPath + "/playerHealth.savefile";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            PlayerData_scr data = formatter.Deserialize(stream) as PlayerData_scr;
            stream.Close();
            return data;
        }
        else
        {
            Debug.Log("No file exists in" + path);
            return null;
        }
    }
}
