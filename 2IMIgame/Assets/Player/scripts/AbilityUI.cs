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

    // Start is called before the first frame update
    void Start()
    {
        // On start, no abilities are aquired, and thus no ability sprite is shown in the UI
        rend.sprite = null;
    }

    // Depending on which ability the player has aquired, an ability sprite will appear in the UI
    void Update()
    {

        if (Abilities.magnet == true)
        {
            rend.sprite = magnet;
        } else
        {
            rend.sprite = null;
        }

        if (Abilities.powerJump == true)
        {
            rend.sprite = powerJump;
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
