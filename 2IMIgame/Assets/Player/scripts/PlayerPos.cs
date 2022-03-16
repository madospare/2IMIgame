using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{

    private GameMaster gm;

    public GameObject player;

    void Start()
    {

        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        transform.position = gm.lastCheckPointPos;

    }

    void Update()
    {
        
        // If player presses the A key, and the input is from local player, the player will teleport back to latest checkpoint
        if(Input.GetKeyDown(KeyCode.A))
        {
            player.transform.position = gm.lastCheckPointPos;
        }

    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {

        // Checkpoint activates when local player touches it
        if (collisionInfo.collider.tag == ("CheckPoint"))
        {
            gm.lastCheckPointPos = transform.position;
        }

        // The local player will return to latest checkpoint if hit by an enemy
        if (collisionInfo.collider.tag == ("Enemy") && PlayerHealth.health != 1 && AB.shieldON != true)
        {
            player.transform.position = gm.lastCheckPointPos;
        }

    }

}
