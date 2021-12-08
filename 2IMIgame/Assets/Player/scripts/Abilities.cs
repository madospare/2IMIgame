using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities : MonoBehaviour
{

    public GameObject player;

    public static bool magnet = false;
    public static bool powerJump = false;
    public static bool shield = false;
    public static bool pushSpell = false;
    public static bool blindness = false;
    public static bool heal = false;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.X))
        {
            UseAbility();
        }

    }

    void UseAbility()
    {

        if (magnet == true)
        {
            player.GetComponent<AB>().Ab_AttractCoins();

            powerJump = false;
            shield = false;
            pushSpell = false;
            blindness = false;
            heal = false;
        }

        if (powerJump == true)
        {

            magnet = false;
            shield = false;
            pushSpell = false;
            blindness = false;
            heal = false;
        }

        if (shield == true)
        {

            magnet = false;
            powerJump = false;
            pushSpell = false;
            blindness = false;
            heal = false;
        }

        if (pushSpell == true)
        {

            magnet = false;
            powerJump = false;
            shield = false;
            blindness = false;
            heal = false;
        }

        if (blindness == true)
        {

            magnet = false;
            powerJump = false;
            shield = false;
            pushSpell = false;
            heal = false;
        }

        if (heal == true)
        {

            magnet = false;
            powerJump = false;
            shield = false;
            pushSpell = false;
            blindness = false;
        }

    }

}
