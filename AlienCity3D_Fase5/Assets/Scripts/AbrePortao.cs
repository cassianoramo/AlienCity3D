using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class AbrePortao : NetworkBehaviour {
	public GameObject PedrasSpawner;
	void Start () {
		NetworkServer.Spawn (PedrasSpawner);
		Vector3 spawnPosition = new Vector3 (-10.24f,-0.43f, 6.501f);
		Instantiate (PedrasSpawner, spawnPosition, Quaternion.Euler (270, 0, 0));
	}

	void Update () {	
		
		}
	}

