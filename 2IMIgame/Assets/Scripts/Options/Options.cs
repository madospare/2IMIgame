using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{

    // For The options menu
    public void Settings()
    {
        SceneManager.LoadScene("Settings");
        FindObjectOfType<AudioManager>().Play("ButtonClick");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
        FindObjectOfType<AudioManager>().Play("ButtonClick");
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Menu");
        FindObjectOfType<AudioManager>().Stop("OtherMenusTheme");
        FindObjectOfType<AudioManager>().Play("MainMenuTheme");
        FindObjectOfType<AudioManager>().Play("ButtonClick");
    }

}
