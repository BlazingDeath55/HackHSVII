using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_Connections : MonoBehaviour {
    public string gameVersion;
	// Use this for initialization
	void Start () {
        PhotonNetwork.ConnectUsingSettings(gameVersion);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void JoinGame()
    {
        RoomOptions ro = new RoomOptions();
        ro.MaxPlayers = 8;
        PhotonNetwork.JoinOrCreateRoom("Default Room", ro, null);
    }
    public void OnJoinedRoom()
    {
        Debug.Log("Joined Room");
    }
}
