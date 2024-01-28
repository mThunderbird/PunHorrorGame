using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TestConnect : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        print("Connecting to server");
        PhotonNetwork.NickName = MasterManager.GameSettings.Nickname;
        PhotonNetwork.GameVersion = MasterManager.GameSettings.GameVersion;
        PhotonNetwork.ConnectUsingSettings();
        PhotonNetwork.JoinLobby();


        Debug.LogError("hi");
    }

    public override void OnConnectedToMaster()
    {
        print("Connected to server successfully\n");
        print(PhotonNetwork.LocalPlayer.NickName);
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        print("Disconnected to server for reason: " + cause.ToString());
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
