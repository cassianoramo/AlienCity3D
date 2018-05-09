using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Colisor : MonoBehaviour {
	public Text Portao;
	int countkey = 0;
	public GameObject door;
	public GameObject Key1;
	public GameObject Key2;
	public Slider slidervida;

	void Start () {
		countkey = GameObject.FindGameObjectsWithTag ("Chave").Length;
	}

	void Update () {
	}
	void  OnTriggerEnter (Collider other){
		if  (other.gameObject.CompareTag ( "Obstaculo")) {
			string currentScene = SceneManager.GetActiveScene ().name;
			SceneManager.LoadScene (currentScene);
		}
		if (other.gameObject.CompareTag("Chave")) {
			countkey--;
			Destroy (other.gameObject);
			Key1.gameObject.SetActive (true);
			if (countkey == 0) {
				Portao.gameObject.SetActive (true);
				door.gameObject.SetActive (false);
				Key2.gameObject.SetActive (true);
			}
		}
	}
	/*public void Vida (float maxvida, float currentvida){
		float newPositionSlider = currentvida * 1 / maxvida;
		slidervida.value = newPositionSlider;
	}*/
}
