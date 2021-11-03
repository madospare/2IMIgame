using GameServer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientHandle : MonoBehaviour
{
   
    public static void Welcome(Packet _packet)
    {

        string _msg = _packet.ReadString();
        int _myId = _packet.ReadInt();

        Debug.Log($"message from server: {_msg}");
        Client.instance.myID = _myId;
        ClientSend.WelcomeReceived();

    }

}
