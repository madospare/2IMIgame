using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AB : MonoBehaviour
{

    public static GameObject radius;
    public static bool magnetON = false;
    public float timer = 40f;

    public GameObject magnetEffect;
    public CharacterController2D controller;
    public int numOfJumps = 6;

    void Start()
    {

        // On start the magnet radius is inactive
        radius = GameObject.FindGameObjectWithTag("MagnetRadius");
        radius.SetActive(false);

    }

    // Sets a timer for how long the ability will last
    void Update()
    {

        if (Abilities.magnet == true)
        {
            timer -= Time.deltaTime;

            if (timer < 0)
            {
                radius.SetActive(false);
                magnetON = false;
                Coin.withinRadius = false;
                Abilities.magnet = false;

                timer = 10;
            }
        } else
        {
            timer = 10;
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

        
        if (Abilities.powerJump == true)
        {
            numOfJumps = 6;
            CharacterController2D.m_JumpForce *= 3f;
            
            if(Input.GetButtonDown("Jump"))
            {
                numOfJumps -= 1;
            }
        }

        if (numOfJumps <= 0)
        {
            CharacterController2D.m_JumpForce = 700f;
            Abilities.powerJump = false;
        }

    }

}
