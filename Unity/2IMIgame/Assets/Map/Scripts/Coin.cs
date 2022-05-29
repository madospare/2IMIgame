using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    private List<GameObject> coin = new List<GameObject>();

    private GameObject player;
    public float magnetSpeed = 10f;

    public bool withinRadius = false;

    public int oneUp = 100;

    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");
        withinRadius = false;

    }

    void Update()
    {

        // If player has activated the magnet, and the coins are within the magnet's radius, the coins will be drawn to the player
        if (withinRadius == true)
        {
            Vector2 dir = player.transform.position - transform.position;
            transform.Translate(dir.normalized * magnetSpeed * Time.deltaTime, Space.World);
        }

        // Coins max number is 999
        if (PlayerCoins.coins > 999)
        {
            PlayerCoins.coins = 999;
        }

    }

    void FixedUpdate()
    {

        // If player gets 100 coins, they get an extra life
        if (PlayerCoins.coins >= oneUp)
        {
            PlayerHealth.health += 1;
            oneUp += 100;
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
                FindObjectOfType<AudioManager>().Play("Coin");
            }
        }

        // If player has activated the magnet and the coin touches the trigger collider of the magnet radius, within radius will be set to true
        if (collision.tag == ("MagnetRadius") && AB.magnetON == true)
        {
            withinRadius = true;
        }

    }

}
