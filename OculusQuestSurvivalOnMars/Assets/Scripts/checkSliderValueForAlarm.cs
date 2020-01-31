using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
This class let's the alarm go off when the radiation is too high or the oxygen is too low.
*/
public class checkSliderValueForAlarm : MonoBehaviour
{
    public AudioSource alarm;
	public GameObject oxygenSlider;
	public GameObject radiationSlider;
	
	private bool alarmPlayed;
	
	void Update(){
		if(!alarmPlayed){
			if(oxygenSlider.GetComponent<Slider>().value <= 10.0f || radiationSlider.GetComponent<Slider>().value >= 90.0f){
				alarm.Play();
				alarmPlayed = true;
			}
		}
	}
}
