using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

    // For the main menu

    // Function for the "Play Game" button
    public void PlayGame()
    {
        SceneManager.LoadScene("Gamemode");
        FindObjectOfType<AudioManager>().Stop("OtherMenusTheme");
        FindObjectOfType<AudioManager>().Play("ButtonClick");

        GameObject gm = GameObject.Find("GameMaster");
        LevelUnlock lockstate = gm.GetComponent<LevelUnlock>();

        lockstate.LoadGame();
    }

    // Function for exiting the game entirely
    public void ExitGame()
    {
        Application.Quit();
        FindObjectOfType<AudioManager>().Play("LevelSelectClick");
        FindObjectOfType<AudioManager>().Stop("Magnet");
    }

    // Function for moving to the options menu
    public void Options()
    {
        SceneManager.LoadScene("Options");
        FindObjectOfType<AudioManager>().Stop("MainMenuTheme");
        FindObjectOfType<AudioManager>().Play("OtherMenusTheme");
        FindObjectOfType<AudioManager>().Play("ButtonClick");
    }

    // Link to support site of the website
    public void BugReport()
    {
        Application.OpenURL("http://10.2.2.255/support.php");
        FindObjectOfType<AudioManager>().Play("LevelSelectClick");
    }

    // Link to the main site of the website
    public void ViewUpdates()
    {
        Application.OpenURL("http://10.2.2.255/index.php");
        FindObjectOfType<AudioManager>().Play("LevelSelectClick");
    }

    // For the gamemode menu

    // Singleplayer button
    public void Singleplayer()
    {
        SceneManager.LoadScene("Stages");

        // Disables player effects for when returning to stage selection after a game
        Abilities.magnet = false;
        Abilities.gravControl = false;
        Abilities.shield = false;
        Abilities.pushSpell = false;
        Abilities.blindness = false;
        Abilities.heal = false;

        FindObjectOfType<AudioManager>().Stop("MainMenuTheme");
        FindObjectOfType<AudioManager>().Stop("LV1Theme");
        FindObjectOfType<AudioManager>().Stop("Magnet");
        FindObjectOfType<AudioManager>().Play("OtherMenusTheme");
        FindObjectOfType<AudioManager>().Play("ButtonClick");
    }

    // Button for returning to the main menu
    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Menu");
        FindObjectOfType<AudioManager>().Play("ButtonClick");
        FindObjectOfType<AudioManager>().Stop("Magnet");
    }

    // Button for returning to the main menu from the pause screen
    public void ExitToMenu()
    {
        SceneManager.LoadScene("Menu");
        FindObjectOfType<AudioManager>().Play("MainMenuTheme");
        FindObjectOfType<AudioManager>().Play("ButtonClick");
        FindObjectOfType<AudioManager>().Stop("LV1Theme");
        FindObjectOfType<AudioManager>().Stop("Magnet");

    }

    // Tutorial
    public void StartTutorial()
    {
        SceneManager.LoadScene("Tutorial");
        FindObjectOfType<AudioManager>().Stop("MainMenuTheme");
        FindObjectOfType<AudioManager>().Play("LevelSelectClick");
    }

    // For starting level 1
    public void StartLv1()
    {
        SceneManager.LoadScene("Lvl1");
        FindObjectOfType<AudioManager>().Stop("OtherMenusTheme");
        FindObjectOfType<AudioManager>().Play("LevelSelectClick");
        FindObjectOfType<AudioManager>().Play("LV1Theme");
    }

    // For returning to the gamemode menu
    public void ReturnToGamemode()
    {
        SceneManager.LoadScene("Gamemode");
        FindObjectOfType<AudioManager>().Stop("OtherMenusTheme");
        FindObjectOfType<AudioManager>().Play("MainMenuTheme");
        FindObjectOfType<AudioManager>().Play("ButtonClick");
    }


}
