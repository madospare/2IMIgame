using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    public GameObject PauseScreen;
    bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {

        ResumeGame();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (!isPaused)
            {
                PauseGame();
                isPaused = true;
            } else
            {
                ResumeGame();
                isPaused = false;
            }
        }



    }

    public void PauseGame()
    {

       PauseScreen.SetActive(true);
        Time.timeScale = 0f;

    }

    public void ResumeGame()
    {

        PauseScreen.SetActive(false);
        Time.timeScale = 1f;

    }

    public void ExitGame()
    {

        Application.Quit();

    }
}
