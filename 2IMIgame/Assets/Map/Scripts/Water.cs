using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{

    public Rigidbody2D rb;
    public GameObject player;

    public static bool isSwimming = false;

    public void Start()
    {

        isSwimming = false;
        rb.gravityScale = 3;
        PlayerMovement.runSpeed = 40f;

    }

    // When player is in water
    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player") && AB.grav != true)
        {
            rb.gravityScale = 6;
            PlayerMovement.runSpeed = 15f;

            isSwimming = true;
        }

    }

    public void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.CompareTag("Player") && AB.grav != true)
        {
            rb.gravityScale = 3;
            PlayerMovement.runSpeed = 40f;

            isSwimming = false;
        }

    }

}
