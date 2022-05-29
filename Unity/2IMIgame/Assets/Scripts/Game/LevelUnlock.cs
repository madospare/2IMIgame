using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelUnlock : MonoBehaviour
{

    public Scene currentScene;
    public string sceneName;

    public bool lv1Cleared;
    public bool lv2Cleared;
    public bool lv3Cleared;

    void Start()
    {

        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name; 

    }

    public void Unlock()
    {

        // If scene named "Lvlx" is cleared, then level x is cleared
        if (sceneName == "Lvl1")
        {
            lv1Cleared = true; 
            GameMaster.lvl1 = true;
        }

        if (sceneName == "Lvl2")
        {
            lv2Cleared = true;
        }

        if (sceneName == "Lvl3")
        {
            lv3Cleared = true;
        }

    }

    // Ignore this
    public void SaveGame()
    {
        SaveSystem.SaveGame(this);
    }

    public void LoadGame()
    {
        PlayerData data = SaveSystem.LoadGame();

        lv1Cleared = data.lv1Cleared;
        lv2Cleared = data.lv2Cleared;
        lv3Cleared = data.lv3Cleared;
    }

}
