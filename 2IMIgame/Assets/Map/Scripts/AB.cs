using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AB : MonoBehaviour
{

    public CharacterController2D controller;

    public static GameObject radius;
    public static bool magnetON = false;
    public static float magnetTimer = 40f;
    public GameObject magnetEffect;

    public static bool jumpBoost = false;
    public static float jumpTimer = 40f;
    public GameObject jumpBoostEffect;
    public GameObject powerJumpEffect;

    public static bool shieldON = false;
    public GameObject shieldBubble;


    void Start()
    {

        // On start the magnet radius is inactive
        radius = GameObject.FindGameObjectWithTag("MagnetRadius");
        radius.SetActive(false);

        // On start the jump effects are inactive
        jumpBoostEffect.SetActive(false);
        powerJumpEffect.SetActive(false);

        // On start the shield bubble is inactive
        shieldBubble.SetActive(false);

    }

    // Sets a timer for how long the ability will last
    void Update()
    {
        
        // Magnet timer
        if (Abilities.magnet == true)
        {
            //Debug.Log();
            magnetTimer -= Time.deltaTime;

            if (magnetTimer < 0)
            {
                radius.SetActive(false);
                magnetON = false;
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
            radius.SetActive(false);
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

    }

    // Function acitvating the magnet and its radius
    public void Ab_AttractCoins()
    {

        radius.SetActive(true);
        magnetON = true;

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

}