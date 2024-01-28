using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class JoinRoom : MonoBehaviourPunCallbacks
{
    [SerializeField] TMP_Text roomCode;
    public void OnClick_JoinRoom()
    {
        Debug.Log(roomCode.text);

        PhotonNetwork.JoinRoom(roomCode.text);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Joined room SUCCESS");
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        Debug.Log("Joined room FAIL: " + message);
    }
}
