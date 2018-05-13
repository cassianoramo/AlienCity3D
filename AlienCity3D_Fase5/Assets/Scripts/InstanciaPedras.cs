using UnityEngine;
using System.Collections;

public class InstanciaPedras : MonoBehaviour {

	public GameObject pedras;
	public Vector3 PosCriacao;
	public int ContaPedras;
	public float EsperaCriacao;


	void Start () {
		StartCoroutine (SpawnPedras ());
	}

	IEnumerator SpawnPedras ()
	{
		for (int i = 0; i < ContaPedras; i++)
		{
			GameObject ped = pedras;
			Vector3 spawnPosition = new Vector3 (Random.Range (87.4f,46.1f),3, Random.Range (-53.73f, 42));
			Instantiate (ped, spawnPosition, Quaternion.Euler(270, 0, 0));
			yield return new WaitForSeconds (EsperaCriacao);
		}
		
	}



}
