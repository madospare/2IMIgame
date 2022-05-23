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

        if (collision.CompareTag("Player"))
        {
            finishScreen.SetActive(true);

            finishedLv = true;

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

            coinScore = PlayerCoins.coins * 100;
            lifeScore = PlayerHealth.health * 1000;

            coinBonus.text = coinScore.ToString();
            lifeBonus.text = lifeScore.ToString();
            totalScore.text = (coinScore + lifeScore).ToString();

            GameObject goal = GameObject.Find("Goal");
            LevelUnlock lockstate = goal.GetComponent<LevelUnlock>();

            lockstate.Unlock();

            lockstate.SaveGame();

        }

    }

}
