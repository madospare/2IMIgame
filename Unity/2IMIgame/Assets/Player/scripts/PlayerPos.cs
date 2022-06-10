using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{

    private GameMaster gm;

    public GameObject player;

    bool isJumping;

    void Start()
    {

        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        transform.position = gm.lastCheckPointPos;

    }

    void Update()
    {
        
        // If player presses the A key, and player is not jumping, the player will teleport back to latest checkpoint
        if(Input.GetKeyDown(KeyCode.A) && isJumping != true)
        {
            player.transform.position = gm.lastCheckPointPos;
            FindObjectOfType<AudioManager>().Play("Checkpoint");
        }

    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {

        // Checkpoint activates when player touches it
        if (collisionInfo.collider.tag == ("CheckPoint"))
        {
            gm.lastCheckPointPos = transform.position;
            PlayerMovement.jump = false;
        }

        // The local player will return to latest checkpoint if hit by an enemy
        if (collisionInfo.collider.tag == ("Enemy") && PlayerHealth.health != 1)
        {
            player.transform.position = gm.lastCheckPointPos;
            PlayerMovement.jump = false;
        }

        isJumping = false;

    }

    // Player is only jumping if not in contact with an object
    void OnCollisionExit2D(Collision2D collision)
    {
        isJumping = true;
    }

}
