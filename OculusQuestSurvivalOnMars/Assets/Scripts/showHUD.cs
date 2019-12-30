using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showHUD : MonoBehaviour
{
	
	public GameObject canvas;
	private GameObject oxygenSlider;
	private GameObject radiationSlider;
	
	void Start(){
		oxygenSlider = GameObject.FindGameObjectWithTag("oxygen");
		radiationSlider = GameObject.FindGameObjectWithTag("radiation");
	}
	
	void OnTriggerEnter(){
		canvas.SetActive(true);
		oxygenSlider.GetComponent<Slider>().SetValueWithoutNotify(100f);
		radiationSlider.GetComponent<Slider>().SetValueWithoutNotify(0f);
	}
}
