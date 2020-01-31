using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Script which starts the machine if all the switches have been activated.
*/
public class solarMachine : MonoBehaviour
{
	public AudioSource audioData;
	public AudioSource audioData2;
	public GameObject light;
	public GameObject electricity;
	public GameObject electricityDefault;
	
	public GameObject oldToDo;
	public GameObject newToDo;
	
	private int count = 0;
	
	private void startMachine(){
		audioData.Play();
		audioData2.PlayDelayed(2);
		light.GetComponent<Light>().color = Color.green;
		electricityDefault.SetActive(false);
		electricity.SetActive(true);
		GameObject.FindGameObjectWithTag("plantsSlider").SetActive(false);
		oldToDo.SetActive(false);
		newToDo.SetActive(true);
		GameObject.FindGameObjectWithTag("nextToDoSound").GetComponent<AudioSource>().Play();
		GameObject.FindGameObjectWithTag("player").GetComponent<playerState>().powerFinished = true;
	}
	
	public void switchActivated(){
		count++;
		if(count == 5){
			startMachine();
		}
	}
}
