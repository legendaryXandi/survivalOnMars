using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
This class toggles the state, if the player is inside or outside.
*/
public class toggleInsideOutside : MonoBehaviour
{
	public GameObject oxygenSlider;
	public GameObject radiationSlider;
	
	void OnTriggerEnter(){
		if(oxygenSlider.GetComponent<Slider>().inside){
			oxygenSlider.GetComponent<Slider>().inside = false;
			radiationSlider.GetComponent<Slider>().inside = false;
		}else{
			oxygenSlider.GetComponent<Slider>().inside = true;
			radiationSlider.GetComponent<Slider>().inside = true;
		}
	}
	
}
