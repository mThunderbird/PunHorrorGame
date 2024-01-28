using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Photon.Realtime;
using UnityEngine.UI;

public class CreateRoom : MonoBehaviourPunCallbacks
{
    public void OnClick_CreateRoom()
    {
        //CreateRoom
        //JoinOrCreateRoom
        if(PhotonNetwork.IsConnected == false)
        {
            return;
        }

        RoomOptions options = new RoomOptions();
        options.MaxPlayers = 5;

        string roomName = Random.Range(0,9999).ToString();

        PhotonNetwork.CreateRoom("1000", options, TypedLobby.Default);
    }

    public override void OnCreatedRoom()
    {
        Debug.Log("Created room SUCCESS: id ", this);
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log("Created room FAIL: " + message, this);
    }
}
