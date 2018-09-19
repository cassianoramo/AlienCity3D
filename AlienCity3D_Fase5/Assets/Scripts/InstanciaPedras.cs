using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class InstanciaPedras : NetworkBehaviour {

	public GameObject pedras;
	public Vector3 PosCriacao;
	//public int ContaPedras;
	//public float EsperaCriacao;


	void Update() {
		CmdSpawnPedras ();
	}
	[Command]
	void CmdSpawnPedras ()
	{
		RpcSpawnPedras ();
		}
	[ClientRpc]
	void RpcSpawnPedras () {

	GameObject ped = pedras;
	Vector3 spawnPosition = new Vector3 (Random.Range (-PosCriacao.x, PosCriacao.x),PosCriacao.y, Random.Range (-PosCriacao.z, PosCriacao.z));
	Instantiate (ped, spawnPosition, Quaternion.Euler(270, 0, 0));
		
	}
}



