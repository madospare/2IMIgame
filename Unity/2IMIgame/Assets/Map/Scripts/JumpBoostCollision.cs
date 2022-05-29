using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoostCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        // When the player touches the power jump, it will disappear while set the power jump bool to true
        if (collision.tag == ("Player"))
        {
            Abilities.gravControl = true;
            FindObjectOfType<AudioManager>().Play("PowerUp");
            Abilities.magnet = false;
            Abilities.shield = false;
            Abilities.pushSpell = false;
            Abilities.blindness = false;
            Abilities.heal = false;
            Destroy(gameObject);

        }

    }

}
