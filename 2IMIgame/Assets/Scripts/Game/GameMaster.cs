using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{

    private static GameMaster instance;
    public Vector2 lastCheckPointPos;

    public GameObject DeathScreen;

    void Start()
    {

        DeathScreen.SetActive(false);

    }

    void Update()
    {

        if (PlayerHealth.health == 0)
        {
            DeathScreen.SetActive(true);
        } else
        {
            return;
        }

        // Cursor is only active when in menus
        if (SceneManager.GetActiveScene() != SceneManager.GetSceneByName("Menu") || DeathScreen.activeSelf == false)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Menu") || DeathScreen.activeSelf == true)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }


    }

    // Death Screen Buttons
    public void Retry()
    {

        SceneManager.LoadScene("Lvl1");

    }

    public void Exit()
    {

        SceneManager.LoadScene("Menu");

    }

}
