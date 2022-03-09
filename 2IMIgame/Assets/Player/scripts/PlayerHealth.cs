using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public static int health;
    public int numOfLives;

    public GameObject player;
    public GameObject deathEffect;
    private Text LivesText;
    private CheckPoint checkPoint;

    void Start()
    {
        health = numOfLives;
        deathEffect.SetActive(false);
    }

    void Update()
    {
        
        if(health > numOfLives)
        {
            health = numOfLives;
        }

    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {

        if (collisionInfo.collider.tag == ("Enemy"))
        {
            health -= 1;
        } 
        
        if (health == 0)
        {
            deathEffect.SetActive(true);
            Instantiate(deathEffect, player.transform.position, player.transform.rotation);
            Destroy(player);
            LivesText.text = "x0";
        }
       
    }

}
