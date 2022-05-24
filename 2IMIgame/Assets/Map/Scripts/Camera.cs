using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public GameObject cam;

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        // Activates a new camera when player enters a new room
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            cam.SetActive(true);
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {

        // Diactivates old cameras when player exits old rooms
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            cam.SetActive(false);
        }

    }

}
