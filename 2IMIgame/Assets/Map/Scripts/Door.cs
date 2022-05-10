using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public static bool doorOpen = false;

    void Start()
    {

        doorOpen = false;

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.collider.tag == "Player" && Key.hasKey == true)
        {
            Destroy(gameObject);
            doorOpen = true;
        }

    }

}
