using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("ConnectToServer");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void BugReport()
    {
        Application.OpenURL("");
        Debug.Log("bug report clicked");
    }

}
