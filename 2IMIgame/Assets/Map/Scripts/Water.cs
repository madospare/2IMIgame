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

        if (collision.CompareTag("Player") && AB.grav != true)
        {
            rb.gravityScale = 6;
            PlayerMovement.runSpeed = 15f;

            isSwimming = true;
            FindObjectOfType<AudioManager>().Play("Splash");
            splashEffect.SetActive(true);
            Instantiate(splashEffect, player.transform.position, player.transform.rotation);
        }

    }

    public void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.CompareTag("Player") && AB.grav != true)
        {
            rb.gravityScale = 3;
            PlayerMovement.runSpeed = 40f;

            isSwimming = false;
            FindObjectOfType<AudioManager>().Play("Splash");
            splashEffect.SetActive(true);
            Instantiate(splashEffect, player.transform.position, player.transform.rotation);
        }

    }

}
