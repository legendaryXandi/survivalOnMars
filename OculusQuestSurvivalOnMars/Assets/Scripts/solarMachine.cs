using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solarMachine : MonoBehaviour
{
	public AudioSource audioData;
	public AudioSource audioData2;
	public GameObject light;
	public GameObject electricity;
	public GameObject electricityDefault;
	
	private int count = 0;
	
	private void startMachine(){
		audioData.Play();
		audioData2.PlayDelayed(2);
		light.GetComponent<Light>().color = Color.green;
		electricityDefault.SetActive(false);
		electricity.SetActive(true);
	}
	
	public void switchActivated(){
		count++;
		if(count == 5){
			startMachine();
		}
	}
}
