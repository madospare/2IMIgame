using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AB : MonoBehaviour
{

    public CharacterController2D controller;

    public static GameObject magnetRadius;
    public static bool magnetON = false;
    public static float magnetTimer = 10f;
    public GameObject magnetEffect;

    public static bool jumpBoost = false;
    public static float jumpTimer = 10f;
    public GameObject jumpBoostEffect;
    public GameObject powerJumpEffect;

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

        // On start the jump effects are inactive
        jumpBoostEffect.SetActive(false);
        powerJumpEffect.SetActive(false);

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
        if (jumpBoost == true)
        {

            controller.m_JumpForce = 1200f;
            jumpBoostEffect.SetActive(true);

            // Power Jump activated when player jumps
            if (Input.GetButton("Jump"))
            {
                powerJumpEffect.SetActive(true);
                
            } else
            {
                powerJumpEffect.SetActive(false);
            }

            jumpTimer -= Time.deltaTime;

            if (jumpTimer < 0)
            {
                controller.m_JumpForce = 700f;
                Abilities.powerJump = false;
                jumpBoost = false;
                jumpBoostEffect.SetActive(false);
                powerJumpEffect.SetActive(false);

                jumpTimer = 10;
            }
        } else
        {
            jumpTimer = 10;
        }

        if (jumpBoost == false)
        {
            controller.m_JumpForce = 700f;
            jumpBoost = false;
            jumpBoostEffect.SetActive(false);
            powerJumpEffect.SetActive(false);
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

        jumpBoost = true;

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