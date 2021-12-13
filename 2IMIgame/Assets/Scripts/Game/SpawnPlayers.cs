using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{

    public GameMaster gm;
    public GameObject playerprefab;


    private void Start()
    {

        // Players are spawned into the game when it starts
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        PhotonNetwork.Instantiate(playerprefab.name, gm.lastCheckPointPos, Quaternion.identity);

    }

}
