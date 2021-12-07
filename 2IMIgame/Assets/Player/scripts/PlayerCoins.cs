using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCoins : MonoBehaviour
{

    public static int coins;

    void Start()
    {

        coins = 0;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == ("Coin"))
        {
            coins += 1;
        }

    }

}
