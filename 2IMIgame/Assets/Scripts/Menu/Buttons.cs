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
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void BugReport()
    {
        Application.OpenURL("http://172.23.176.29/HTML/support.html");
    }

    public void ViewUpdates()
    {
        Application.OpenURL("http://172.23.176.29/index.html");
    }

    // For the gamemode menu
    public void Singleplayer()
    {
        SceneManager.LoadScene("Stages");
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    // For the stages menu
    public void StartLv1()
    {
        SceneManager.LoadScene("Lvl1");
    }

    public void StartLv2()
    {
        SceneManager.LoadScene("Lvl2");
    }

    public void StartLv3()
    {
        SceneManager.LoadScene("Lvl3");
    }

    public void ReturnToGamemode()
    {
        SceneManager.LoadScene("Gamemode");
    }


}
