using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{

    private GameMaster gm;

    void Start()
    {

        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();

    }

    void OnTriggerEnter2D(Collider2D other)
    {

        // If player touches a checkpoint, the checkpoint will activate and replace previous checkpoint
        if(other.CompareTag("Player"))
        {
            gm.lastCheckPointPos = transform.position;
        }

    }

}
