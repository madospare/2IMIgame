using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using UnityEngine.UI;

public class ConnectToServer : MonoBehaviourPunCallbacks
{

    public InputField usernameInput;
    public Text buttonText;

    // Sets username to what the player has written in input field, and when the "connect" button is pressed, the player will enter the lobby scene
    public void OnClickConnect() 
    {

        if (usernameInput.text.Length >= 1)
        {
            PhotonNetwork.NickName = usernameInput.text;
            buttonText.text = "Connecting...";
            PhotonNetwork.ConnectUsingSettings();
        }

    }

    // The lobby scene will be loaded
    public override void OnConnectedToMaster()
    {

        SceneManager.LoadScene("Lobby");

    }

}
