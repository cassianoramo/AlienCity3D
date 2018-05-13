using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUDController : MonoBehaviour {
	
	public Slider slidervida;

	void Start () {
	}
	void Update () {
		
		}
	public void Vida (float maxvida, float currentvida){
		float newPositionSlider = currentvida * 1 / maxvida;
		slidervida.value = newPositionSlider;
	}
}



