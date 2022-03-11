using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityUI : MonoBehaviour
{

    public SpriteRenderer rend;

    public Sprite magnet;
    public Sprite powerJump;
    public Sprite shield;
    public Sprite pushSpell;
    public Sprite blindness;
    public Sprite heal;

    public Text numTimer;

    // Start is called before the first frame update
    void Start()
    {
        // On start, no abilities are aquired, and thus no ability sprite is shown in the UI
        rend.sprite = null;

        // On start, no timer is applied
        numTimer.gameObject.SetActive(false);
    }

    // Depending on which ability the player has aquired, an ability sprite will appear in the UI
    void Update()
    {

        if (Abilities.magnet == true)
        {
            rend.sprite = magnet;

            // Enable the magnet timer
            if (AB.magnetON == true)
            {
                numTimer.gameObject.SetActive(true);
                numTimer.text = AB.magnetTimer.ToString("F0");
            }
        } else
        {
            rend.sprite = null;

            if (AB.magnetON == false)
            {
                numTimer.gameObject.SetActive(false);
            }
        }

        if (Abilities.powerJump == true)
        {
            rend.sprite = powerJump;

            // Enable the Power Jump timer
            if (AB.jumpBoost == true)
            {
                numTimer.gameObject.SetActive(true);
                numTimer.text = AB.jumpTimer.ToString("F0");
            } else
            {
                if (AB.jumpBoost == false)
                {
                    numTimer.gameObject.SetActive(false);
                }
            }
        }

        if (Abilities.shield == true)
        {
            rend.sprite = shield;
        }

        if (Abilities.pushSpell == true)
        {
            rend.sprite = pushSpell;
        }

        if (Abilities.blindness == true)
        {
            rend.sprite = blindness;
        }

        if (Abilities.heal == true)
        {
            rend.sprite = heal;
        }

    }

}
