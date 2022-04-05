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

        Abilities.magnet = false;
        Abilities.gravControl = false;
        Abilities.shield = false;
        Abilities.pushSpell = false;
        Abilities.blindness = false;
        Abilities.heal = false;

        FindObjectOfType<AudioManager>().Play("ButtonClick");
        FindObjectOfType<AudioManager>().Stop("Magnet");

    }

    public void ExitToScene()
    {

        SceneManager.LoadScene("Stages");

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
        FindObjectOfType<AudioManager>().Play("OtherMenusTheme");
        FindObjectOfType<AudioManager>().Stop("Magnet");

    }

}
