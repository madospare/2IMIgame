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

    public int shieldLife;
    public Sprite healthIcon;
    public Sprite defendedHeart;
    public SpriteRenderer rend;

    void Start()
    {

        health = numOfLives;
        deathEffect.SetActive(false);

    }

    void Update()
    {
        
        // If player has no shield and player health is above max lives,
        // health will turn equal to max number of lives
        if (health > numOfLives && Abilities.shield != true)
        {
            health = numOfLives;
        }

        // Replace heart with shielded heart when shield is active
        if (AB.shieldON == true) {
            rend.sprite = defendedHeart;
        } else
        {
            rend.sprite = healthIcon;
        }

    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {

        // If player collides with enemy, and player has no shield,
        // player loses a life
        if (collisionInfo.collider.tag == ("Enemy") && AB.shieldON != true)
        {
            health -= 1;
            FindObjectOfType<AudioManager>().Play("Hurt");
        } 
        
        // If player has 0 lives, plauer dies and death effect plays
        if (health == 0)
        {
            deathEffect.SetActive(true);
            Instantiate(deathEffect, player.transform.position, player.transform.rotation);
            player.SetActive(false);
            LivesText.text = "x0";
        }

        // For when player collides with enemy while shielded
        if (collisionInfo.collider.tag == ("Enemy") && AB.shieldON == true)
        {
            shieldLife -= 1;
        }

        // For when player collides with projectiles while shielded
        if (collisionInfo.collider.tag == ("Enemy") && collisionInfo.collider.gameObject.layer == 12 && AB.shieldON == true)
        {
            AB.shieldON = true;
            Abilities.shield = true;
            shieldLife = 1;
        }

        // If shield is destroyed, disable shield
        if (shieldLife == 0)
        {
            AB.shieldON = false;
            Abilities.shield = false;
            rend.sprite = healthIcon;
        }
       
    }

}
