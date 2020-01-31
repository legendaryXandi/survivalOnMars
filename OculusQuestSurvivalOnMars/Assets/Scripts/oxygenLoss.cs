using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
Script which increases the oxygen loss when the trigger is entered
*/
public class oxygenLoss : MonoBehaviour
{
    public GameObject oxygenSlider;
	
	void OnTriggerEnter(){
		if(GameObject.FindGameObjectWithTag("player").GetComponent<playerState>().powerFinished){
			oxygenSlider.GetComponent<Slider>().oxygenLoss = 2.0f;
		}
	}
}
