using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class InstanciaPedras : NetworkBehaviour {

	public GameObject pedras;
	public Vector3 PosCriacao;
	[SyncVar]
	public int ContaPedras = 0;
	[SyncVar]
	public int num;

	void Start(){
		if (!isLocalPlayer) {
			return;
		}
		if(ContaPedras == 0) {
			num = Random.Range (0, 5);
		}
		if(ContaPedras == 0 && num == 0) {
			GameObject ped = pedras;
			Vector3 spawnPosition = new Vector3 (-40.73f,-0.43f, -13.32379f);
			Instantiate (ped, spawnPosition, Quaternion.Euler (270, 0, 0));
			NetworkServer.Spawn (ped);
			ContaPedras = 1;
		}
		if(ContaPedras == 0 && num == 1) {
			GameObject ped = pedras;
			Vector3 spawnPosition = new Vector3 (-23.55f,-0.43f,-8.11f);
			Instantiate (ped, spawnPosition, Quaternion.Euler (270, 0, 0));
			NetworkServer.Spawn (ped);
			ContaPedras = 1;
		}
		if(ContaPedras == 0 && num == 2) {
			GameObject ped = pedras;
			Vector3 spawnPosition = new Vector3 (-10.24f,-0.43f, 6.501f);
			Instantiate (ped, spawnPosition, Quaternion.Euler (270, 0, 0));
			NetworkServer.Spawn (ped);
			ContaPedras = 1;
		}
		if(ContaPedras == 0 && num == 3) {
			GameObject ped = pedras;
			Vector3 spawnPosition = new Vector3 (-33.2f,-0.43f, 2.62f);
			Instantiate (ped, spawnPosition, Quaternion.Euler (270, 0, 0));
			NetworkServer.Spawn (ped);
			ContaPedras = 1;
		}
		if(ContaPedras == 0 && num == 4) {
			GameObject ped = pedras;
			Vector3 spawnPosition = new Vector3 (-39.83f,-0.43f, 2.27f);
			Instantiate (ped, spawnPosition, Quaternion.Euler (270, 0, 0));
			NetworkServer.Spawn (ped);
			ContaPedras = 1;
		}
		if (ContaPedras == 1) {
			return;
		}
	}
	/*void Update() {
		CmdSpawnPedras ();
	}
	[Command]
	void CmdSpawnPedras ()
	{

		RpcSpawnPedras ();
		}
	[ClientRpc]
	void RpcSpawnPedras () {

		if(ContaPedras == 0 && num == 0) {
		GameObject ped = pedras;
		Vector3 spawnPosition = new Vector3 (-40.73f,-0.43f, -13.32379f);
		Instantiate (ped, spawnPosition, Quaternion.Euler (270, 0, 0));
		ContaPedras = 1;
		ContaPedras1 = 1;
	}
		if(ContaPedras == 0 && num == 1) {
			GameObject ped = pedras;
			Vector3 spawnPosition = new Vector3 (-23.55f,-0.43f,-8.11f);
			Instantiate (ped, spawnPosition, Quaternion.Euler (270, 0, 0));
			ContaPedras = 1;
			ContaPedras1 = 1;
		}
		if(ContaPedras == 0 && num == 2) {
			GameObject ped = pedras;
			Vector3 spawnPosition = new Vector3 (-10.24f,-0.43f, 6.501f);
			Instantiate (ped, spawnPosition, Quaternion.Euler (270, 0, 0));
			ContaPedras = 1;
			ContaPedras1 = 1;
		}
		if(ContaPedras == 0 && num == 3) {
			GameObject ped = pedras;
			Vector3 spawnPosition = new Vector3 (-33.2f,-0.43f, 2.62f);
			Instantiate (ped, spawnPosition, Quaternion.Euler (270, 0, 0));
			ContaPedras = 1;
			ContaPedras1 = 1;
		}
		if(ContaPedras == 0 && num == 4) {
			GameObject ped = pedras;
			Vector3 spawnPosition = new Vector3 (-39.83f,-0.43f, 2.27f);
			Instantiate (ped, spawnPosition, Quaternion.Euler (270, 0, 0));
			ContaPedras = 1;
			ContaPedras1 = 1;
		}
		if (ContaPedras == 1) {
			return;
		}*/
	}




