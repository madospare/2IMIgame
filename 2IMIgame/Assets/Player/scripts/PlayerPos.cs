using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class PlayerPos : MonoBehaviour
{

    private GameMaster gm;

    public GameObject player;

    PhotonView view;

    void Start()
    {

        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        transform.position = gm.lastCheckPointPos;

        view = GetComponent<PhotonView>();

    }

    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.A) && view.IsMine)
        {
            player.transform.position = gm.lastCheckPointPos;
        }

    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {

        if (collisionInfo.collider.tag == ("CheckPoint") && view.IsMine)
        {
            gm.lastCheckPointPos = transform.position;
        }

        if (collisionInfo.collider.tag == ("Enemy") && view.IsMine)
        {
            player.transform.position = gm.lastCheckPointPos; ;
        }

    }

}
