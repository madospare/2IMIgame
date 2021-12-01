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
        
        if(Input.GetKeyDown(KeyCode.A))
        {
            player.transform.position = gm.lastCheckPointPos;
        }

    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {

        if (collisionInfo.collider.tag == ("Enemy"))
        {
            gm.lastCheckPointPos = transform.position;
        }

    }

}
