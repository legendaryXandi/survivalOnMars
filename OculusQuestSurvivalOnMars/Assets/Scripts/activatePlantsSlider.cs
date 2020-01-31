using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
This class activates the slider which indicates the remaining time to save the plants from freezing.
*/
public class activatePlantsSlider : MonoBehaviour
{
    public GameObject plantsSlider;
	private bool alreadyActivated;
	
	void OnTriggerEnter(){
		if(!alreadyActivated){
			if(GameObject.FindGameObjectWithTag("player").GetComponent<playerState>().drillingStationFinished){
				plantsSlider.SetActive(true);
				alreadyActivated = true;
			}
		}
	}
}
