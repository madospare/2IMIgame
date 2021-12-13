using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{

    public InputField createInput;
    public InputField JoinInput;

    // Room will be created with text written by player in the input field
    public void CreateRoom()
    {

        PhotonNetwork.CreateRoom(createInput.text);

    }

    // Room will be joined with text written by player in the input field
    public void JoinRoom()
    {

        PhotonNetwork.JoinRoom(JoinInput.text);

    }

    // When entering a room, the lvl 1 scene will be loaded
    public override void OnJoinedRoom()
    {

        PhotonNetwork.LoadLevel("Lvl1");

    }

}
