using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities : MonoBehaviour
{

    public GameObject GameMaster;

    public bool hasAbility = false;

    public static bool magnet = false;
    public static bool powerJump = false;
    public static bool shield = false;
    public static bool pushSpell = false;
    public static bool blindness = false;
    public static bool heal = false;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.X) && hasAbility == true)
        {
            UseAbility();
            hasAbility = false;
        }

    }

    void UseAbility()
    {

        if (magnet == true)
        {
            GameMaster.GetComponent<AB>().Ab_AttractCoins();
            hasAbility = true;
        }

        if (powerJump == true)
        {
            hasAbility = true;
        }

        if (shield == true)
        {
            hasAbility = true;
        }

        if (pushSpell == true)
        {
            hasAbility = true;
        }

        if (blindness == true)
        {
            hasAbility = true;
        }

        if (heal == true)
        {
            hasAbility = true;
        }

    }

}
