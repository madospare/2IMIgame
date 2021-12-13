using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCoins : MonoBehaviour
{

    public static int coins;

    void Start()
    {

        // Players will start with 0 coins
        coins = 0;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        // If player touches a coin, it will be added to the player's score
        if (collision.tag == ("Coin"))
        {
            coins += 1;
        }

    }

}
