using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene("Stages");

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

            Abilities.magnet = false;
            Abilities.gravControl = false;
            Abilities.shield = false;
            Abilities.pushSpell = false;
            Abilities.blindness = false;
            Abilities.heal = false;

            FindObjectOfType<AudioManager>().Stop("MainMenuTheme");
            FindObjectOfType<AudioManager>().Play("OtherMenusTheme");
            FindObjectOfType<AudioManager>().Stop("Magnet");
        }

    }

}
