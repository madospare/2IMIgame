using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetCollision : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        // When the player touches the magnet, it will disappear while set the magnet bool to true
        if (collision.tag == ("Player"))
        {
            Abilities.magnet = true;
            FindObjectOfType<AudioManager>().Play("PowerUp");
            Abilities.gravControl = false;
            Abilities.shield = false;
            Abilities.pushSpell = false;
            Abilities.blindness = false;
            Abilities.heal = false;
            Destroy(gameObject);
            
        }

    }

}
