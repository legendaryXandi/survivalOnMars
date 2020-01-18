using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggleInsideOutside : MonoBehaviour
{
	public GameObject oxygenSlider;
	public GameObject radiationSlider;
	
	void OnTriggerEnter(){
		if(oxygenSlider.GetComponent<Slider>().inside){
			oxygenSlider.GetComponent<Slider>().inside = false;
		}else{
			oxygenSlider.GetComponent<Slider>().inside = true;
		}
	}
	
}
