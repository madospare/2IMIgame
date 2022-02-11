using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Lvl1");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void BugReport()
    {
        Application.OpenURL("http://localhost/2IMIGame/nettside/HTML/support.html");
        Debug.Log("bug report clicked");
    }

    public void ViewUpdates()
    {
        Application.OpenURL("http://localhost/2IMIGame/nettside/index.html");
        Debug.Log("updates report clicked");
    }

}
