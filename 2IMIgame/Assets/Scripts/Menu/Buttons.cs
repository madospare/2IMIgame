using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

    // For the main menu
    public void PlayGame()
    {
        SceneManager.LoadScene("Gamemode");
        FindObjectOfType<AudioManager>().Stop("OtherMenusTheme");
        FindObjectOfType<AudioManager>().Play("ButtonClick");

        GameObject gm = GameObject.Find("GameMaster");
        LevelUnlock lockstate = gm.GetComponent<LevelUnlock>();

        lockstate.LoadGame();
    }

    public void ExitGame()
    {
        Application.Quit();
        FindObjectOfType<AudioManager>().Play("LevelSelectClick");
        FindObjectOfType<AudioManager>().Stop("Magnet");
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
        FindObjectOfType<AudioManager>().Stop("MainMenuTheme");
        FindObjectOfType<AudioManager>().Play("OtherMenusTheme");
        FindObjectOfType<AudioManager>().Play("ButtonClick");
    }

    public void BugReport()
    {
        Application.OpenURL("http://172.23.111.67/HTML/support.html");
        FindObjectOfType<AudioManager>().Play("LevelSelectClick");
    }

    public void ViewUpdates()
    {
        Application.OpenURL("http://172.23.111.67/index.html");
        FindObjectOfType<AudioManager>().Play("LevelSelectClick");
    }

    // For the gamemode menu
    public void Singleplayer()
    {
        SceneManager.LoadScene("Stages");

        Abilities.magnet = false;
        Abilities.gravControl = false;
        Abilities.shield = false;
        Abilities.pushSpell = false;
        Abilities.blindness = false;
        Abilities.heal = false;

        FindObjectOfType<AudioManager>().Stop("MainMenuTheme");
        FindObjectOfType<AudioManager>().Play("OtherMenusTheme");
        FindObjectOfType<AudioManager>().Play("ButtonClick");
        FindObjectOfType<AudioManager>().Stop("Magnet");
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Menu");
        FindObjectOfType<AudioManager>().Play("ButtonClick");
        FindObjectOfType<AudioManager>().Stop("Magnet");
    }

    public void ExitToMenu()
    {
        SceneManager.LoadScene("Menu");
        FindObjectOfType<AudioManager>().Play("MainMenuTheme");
        FindObjectOfType<AudioManager>().Play("ButtonClick");
        FindObjectOfType<AudioManager>().Stop("Magnet");

    }

    // Tutorial
    public void StartTutorial()
    {
        SceneManager.LoadScene("Tutorial");
        FindObjectOfType<AudioManager>().Stop("MainMenuTheme");
        FindObjectOfType<AudioManager>().Play("LevelSelectClick");
    }

    // For the stages menu
    public void StartLv1()
    {
        SceneManager.LoadScene("Lvl1");
        FindObjectOfType<AudioManager>().Stop("OtherMenusTheme");
        FindObjectOfType<AudioManager>().Play("LevelSelectClick");
    }

    public void ReturnToGamemode()
    {
        SceneManager.LoadScene("Gamemode");
        FindObjectOfType<AudioManager>().Stop("OtherMenusTheme");
        FindObjectOfType<AudioManager>().Play("MainMenuTheme");
        FindObjectOfType<AudioManager>().Play("ButtonClick");
    }


}
