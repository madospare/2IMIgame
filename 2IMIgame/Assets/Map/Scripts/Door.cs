using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.collider.tag == "Player" && Key.hasKey == true)
        {
            FindObjectOfType<AudioManager>().Play("Door");
            Destroy(gameObject);
            Key.hasKey = false;
        }

    }

}
