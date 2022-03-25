using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AB : MonoBehaviour
{

    public CharacterController2D controller;
    public Rigidbody2D rb;
    public GameObject player;

    public static GameObject magnetRadius;
    public static bool magnetON = false;
    public static float magnetTimer = 10f;
    public GameObject magnetEffect;

    public static bool grav = false;
    public static float gravTimer = 10f;
    public bool gravSwap = false;
    public GameObject gravControlEffect;

    public static bool shieldON = false;
    public GameObject shieldBubble;

    public static bool push = false;
    public static GameObject pushRadius;
    public static CircleCollider2D pushCollider;


    void Start()
    {

        // On start the magnet radius is inactive
        magnetRadius = GameObject.FindGameObjectWithTag("MagnetRadius");
        magnetRadius.SetActive(false);

        // On start the jump effect is inactive
        gravControlEffect.SetActive(false);

        // On start the shield bubble is inactive
        shieldBubble.SetActive(false);
        shieldON = false;

        // On start the push radius is inactive
        pushRadius = GameObject.FindGameObjectWithTag("PushRadius");
        pushCollider = pushRadius.GetComponent<CircleCollider2D>();
        pushCollider.radius = 0.05f;
        pushRadius.SetActive(false);

    }

    // Sets a timer for how long the ability will last
    void Update()
    {
        
        // Magnet timer
        if (Abilities.magnet == true)
        {
            magnetTimer -= Time.deltaTime;

            if (magnetTimer < 0)
            {
                magnetRadius.SetActive(false);
                magnetON = false;
                FindObjectOfType<AudioManager>().Stop("Magnet");
                Coin.withinRadius = false;
                Abilities.magnet = false;

                magnetTimer = 10;
            }
        } else
        {
            magnetTimer = 10;
        }

        if (Abilities.magnet == false)
        {
            magnetRadius.SetActive(false);
            magnetON = false;
            Coin.withinRadius = false;
        }

        // Power Jump timer
        if (grav == true)
        {
            gravControlEffect.SetActive(true);
            Water.isSwimming = false;
            PlayerMovement.runSpeed = 40f;

            // Power Jump activated when player jumps
            if (Input.GetButtonDown("Jump") && gravSwap == false)
            {
                rb.gravityScale = -3;
                player.transform.localScale = new Vector2(player.transform.localScale.x, -20);
                gravSwap = true;
                
            } else if (Input.GetButtonDown("Jump") && gravSwap == true)
            {
                rb.gravityScale = 3;
                player.transform.localScale = new Vector2(player.transform.localScale.x, 20);
                gravSwap = false;
            }

            gravTimer -= Time.deltaTime;

            if (gravTimer < 0)
            {
                rb.gravityScale = 3;
                player.transform.localScale = new Vector2(player.transform.localScale.x, 20);
                gravSwap = false;
                Abilities.gravControl = false;
                grav = false;
                gravControlEffect.SetActive(false);

                gravTimer = 10;
            }
        } else
        {
            gravTimer = 10;
        }

        if (grav == false)
        {
            controller.m_JumpForce = 700f;
            grav = false;
            gravControlEffect.SetActive(false);
        }

        // Shield bubble
        if (shieldON == true)
        {
            shieldBubble.SetActive(true);
        }
        else
        {
            shieldBubble.SetActive(false);
        }

        // Push spell
        if (push == true && Time.timeScale != 0f)
        {
            pushRadius.SetActive(true);
            pushCollider.radius += 0.002f;
            ParticleSystem.ShapeModule pushEffect = pushRadius.GetComponent<ParticleSystem>().shape;
            pushEffect.radius += 0.15f;

            if (pushCollider.radius > 0.5f)
            {
                pushRadius.SetActive(false);
                pushCollider.radius = 0.05f;
                push = false;
                Abilities.pushSpell = false;
                FindObjectOfType<AudioManager>().Stop("Magnet");
                FindObjectOfType<AudioManager>().Play("PushSpell");

            }
        }

    }

    // Function acitvating the magnet and its radius
    public void Ab_AttractCoins()
    {

        magnetRadius.SetActive(true);
        magnetON = true;

        if (magnetON == true)
        {
            FindObjectOfType<AudioManager>().Play("Magnet");
        }

    }

    // Function activating the power jump
    public void Ab_JumpBoost()
    {

        grav = true;

    }

    // Function activating the shield
    public void Ab_Shield()
    {

        shieldON = true;

    }

    // Function activating the push spell
    public void Ab_Push()
    {

        push = true;

        FindObjectOfType<AudioManager>().Play("Magnet");

    }

}