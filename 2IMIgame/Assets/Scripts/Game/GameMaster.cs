using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{

    public Vector2 lastCheckPointPos;

    public GameObject DeathScreen;

    public Rigidbody2D rb;

    public static bool lvl1;

    void Start()
    {

        DeathScreen.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }

    void Update()
    {

        // Enables the death screen when player has 0 lives
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
        
        // Disable all player effects when restarting
        Abilities.magnet = false;
        Abilities.gravControl = false;
        Abilities.shield = false;
        Abilities.pushSpell = false;
        Abilities.blindness = false;
        Abilities.heal = false;

        Water.isSwimming = false;
        rb.gravityScale = 3;
        PlayerMovement.runSpeed = 40f;

        FindObjectOfType<AudioManager>().Play("ButtonClick");
        FindObjectOfType<AudioManager>().Stop("Magnet");

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void ExitToScene()
    {

        // Disable all player effects when exiting
        Abilities.magnet = false;
        Abilities.gravControl = false;
        Abilities.shield = false;
        Abilities.pushSpell = false;
        Abilities.blindness = false;
        Abilities.heal = false;

        Water.isSwimming = false;
        rb.gravityScale = 3;
        PlayerMovement.runSpeed = 40f;

        FindObjectOfType<AudioManager>().Stop("LV1Theme");
        FindObjectOfType<AudioManager>().Stop("Magnet");
        FindObjectOfType<AudioManager>().Play("ButtonClick");
        FindObjectOfType<AudioManager>().Play("OtherMenusTheme");

        SceneManager.LoadScene("Stages");

    }

}
