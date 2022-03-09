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

    }

    public void Retry()
    {

        SceneManager.LoadScene("Lvl1");

    }

    public void Exit()
    {

        SceneManager.LoadScene("Menu");

    }

}
