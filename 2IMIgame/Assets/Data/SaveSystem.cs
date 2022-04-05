using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{

    public static void SaveGame (LevelUnlock lockstate)
    {

        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.data";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(lockstate);

        formatter.Serialize(stream, data);
        stream.Close();

        Debug.Log("Game Saved");

    }

    public static PlayerData LoadGame ()
    {

        string path = Application.persistentDataPath + "/player.data";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            Debug.Log("Game Loaded");

            return data;
        } else
        {
            Debug.LogError("Save file not found in" + path + "!");
            return null;
        }

    }

}
