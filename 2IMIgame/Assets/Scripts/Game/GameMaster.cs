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
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

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
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Menu") || DeathScreen.activeSelf == true)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        } else
        {
            
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }


    }

    // Death Screen Buttons
    public void Retry()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void Exit()
    {

        SceneManager.LoadScene("Stages");

    }

}
