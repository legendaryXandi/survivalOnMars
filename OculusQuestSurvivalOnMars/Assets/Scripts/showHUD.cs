using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showHUD : MonoBehaviour
{
	
	public GameObject canvas;
	public GameObject oxygenSlider;
	public GameObject radiationSlider;
	private bool alreadyTriggered;
	
	void OnTriggerEnter(){
		if(!alreadyTriggered){
			canvas.GetComponent<Canvas>().enabled = true;
			oxygenSlider.GetComponent<Slider>().value = 100f;
			radiationSlider.GetComponent<Slider>().value = 0f;
			alreadyTriggered = true;
		}
	}
}
