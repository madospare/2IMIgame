using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{

    public Rigidbody2D rb;
    public GameObject player;
    public GameObject splashEffect;

    public static bool isSwimming = false;

    public void Start()
    {

        isSwimming = false;
        rb.gravityScale = 3;
        PlayerMovement.runSpeed = 40f;
        splashEffect.SetActive(false);

    }

    // When player is in water
    public void OnTriggerEnter2D(Collider2D collision)
    {

        // Reduces movement speed and adds more gravity
        if (collision.CompareTag("Player") && AB.grav != true)
        {
            rb.gravityScale = 6;
            PlayerMovement.runSpeed = 15f;

            isSwimming = true;

            // Creates a splash effect when player goes into the water
            FindObjectOfType<AudioManager>().Play("Splash");
            splashEffect.SetActive(true);
            Instantiate(splashEffect, player.transform.position, player.transform.rotation);
        }

    }

    public void OnTriggerExit2D(Collider2D collision)
    {

        // When player exits, reverts all gravity and speed changes
        if (collision.CompareTag("Player") && AB.grav != true)
        {
            rb.gravityScale = 3;
            PlayerMovement.runSpeed = 40f;

            isSwimming = false;

            // Creates a splash effect when player exits the water
            FindObjectOfType<AudioManager>().Play("Splash");
            splashEffect.SetActive(true);
            Instantiate(splashEffect, player.transform.position, player.transform.rotation);
        }

    }

}
