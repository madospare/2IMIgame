using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushSpellCollision : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {

        // When the player touches the push spell, it will disappear while set the pushSpell bool to true
        if (collision.tag == ("Player"))
        {
            Abilities.pushSpell = true;
            FindObjectOfType<AudioManager>().Play("PowerUp");
            Abilities.magnet = false;
            Abilities.powerJump = false;
            Abilities.shield = false;
            Abilities.blindness = false;
            Abilities.heal = false;
            Destroy(gameObject);

        }

    }

}
