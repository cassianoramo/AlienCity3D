using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrePortao : MonoBehaviour {
	int countkey = 0;
	private Animator anima;
	// Use this for initialization
	void Start () {
		countkey = GameObject.FindGameObjectsWithTag ("Chave").Length;
		anima = GetComponent<Animator> ();
	}
	// Update is called once per frame
	void Update () {	
		if (countkey == 0) {
			anima.SetTrigger ("Abre");
		}
	}
}
