using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{

    public static bool finishedLv;

    public GameObject finishScreen;

    public Text coinBonus;
    public Text lifeBonus;
    public Text totalScore;

    public int coinScore = 0;
    public int lifeScore = 0;

    void Start()
    {

        finishedLv = false;

        finishScreen.SetActive(false);
        Time.timeScale = 1;

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        // If player reaches goal
        if (collision.CompareTag("Player"))
        {
            finishScreen.SetActive(true); // Finish Screen will pop up

            finishedLv = true; // The level will be finished

            // Pauses game, enables cursor, and deactivates all active effects on player
            Time.timeScale = 0;

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

            Abilities.magnet = false;
            Abilities.gravControl = false;
            Abilities.shield = false;
            Abilities.pushSpell = false;
            Abilities.blindness = false;
            Abilities.heal = false;

            FindObjectOfType<AudioManager>().Stop("Magnet");

            // Sets how much score for coins and lives
            coinScore = PlayerCoins.coins * 100;
            lifeScore = PlayerHealth.health * 1000;

            // Converts points to string and sets the total score
            coinBonus.text = coinScore.ToString();
            lifeBonus.text = lifeScore.ToString();
            totalScore.text = (coinScore + lifeScore).ToString();

            // Next level is unlocked
            GameObject goal = GameObject.Find("Goal");
            LevelUnlock lockstate = goal.GetComponent<LevelUnlock>();

            lockstate.Unlock();

            //lockstate.SaveGame();

        }

    }

}
