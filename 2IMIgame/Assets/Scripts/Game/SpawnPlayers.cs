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

        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        PhotonNetwork.Instantiate(playerprefab.name, gm.lastCheckPointPos, Quaternion.identity);

    }

}
