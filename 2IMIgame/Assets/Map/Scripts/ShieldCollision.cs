using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        // When the player touches the shield, it will disappear while set the shield bool to true
        if (collision.tag == ("Player"))
        {
            Abilities.shield = true;
            FindObjectOfType<AudioManager>().Play("PowerUp");
            Abilities.gravControl = false;
            Abilities.magnet = false;
            Abilities.pushSpell = false;
            Abilities.blindness = false;
            Abilities.heal = false;
            Destroy(gameObject);

        }

    }

}
