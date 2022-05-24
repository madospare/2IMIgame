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

        ResumeGame(); // Game does not start paused

    }

    // Update is called once per frame
    void Update()
    {

        // If enter is pressed, and player is not dead or level is not cleared, then pause
        if (Input.GetKeyDown(KeyCode.Return) && PlayerHealth.health > 0 && Goal.finishedLv != true)
        {
            if (!isPaused) // Pause only if not already paused
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

    // Function that enables the pause screen and pauses the game
    public void PauseGame()
    {

        PauseScreen.SetActive(true);
        Time.timeScale = 0f;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        FindObjectOfType<AudioManager>().Play("ButtonClick");

    }

    // Function that disables the pause screen and unpauses the game 
    public void ResumeGame()
    {

        PauseScreen.SetActive(false);
        Time.timeScale = 1f;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        FindObjectOfType<AudioManager>().Play("ButtonClick");

    }

}
