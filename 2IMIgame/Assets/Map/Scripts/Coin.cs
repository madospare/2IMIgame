using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    private GameObject player;
    public float magnetSpeed = 10f;

    public static bool withinRadius = false;

    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");

    }

    void Update()
    {

        // If player has activated the magnet, and the coins are within the magnet's radius, the coins will be drawn to the player
        if (AB.magnetON == true && withinRadius == true)
        {
            Vector2 dir = player.transform.position - transform.position;
            transform.Translate(dir.normalized * magnetSpeed * Time.deltaTime, Space.World);
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        // If the player touches a coin, it disappears
        if (collision.tag == ("Player"))
        {
            Destroy(gameObject);
            // If player touches a coin, it will be added to the player's score
            if (collision.tag == ("Player"))
            {
                PlayerCoins.coins += 1;
            }
        }

        // If player has activated the magnet and the coin touches the trigger collider of the magnet radius, within radius will be set to true
        if (collision.tag == ("MagnetRadius") && AB.magnetON == true)
        {
            withinRadius = true;
        }

    }

}
