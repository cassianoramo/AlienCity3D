using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUDController : MonoBehaviour {
	
	public Slider slidervida;
	/*int contcoracao = 0;
	public GameObject Heart;
	public GameObject Heart1;
	public GameObject Heart2;
	*/

	void Start () {
		/*contcoracao = GameObject.FindGameObjectsWithTag ("Vida").Length;*/
	}
	void Update () {
		
		}
	public void Vida (float maxvida, float currentvida){
		float newPositionSlider = currentvida * 1 / maxvida;
		slidervida.value = newPositionSlider;
		/*if (currentvida == 0) {
			contcoracao--;
		}
		if (contcoracao == 2) {
			Heart2.SetActive (false);
		}
		if (contcoracao == 1) {
			Heart1.SetActive (false);
		}
		if (contcoracao == 0) {
			Heart.SetActive (false);
		}*/
	}
}



