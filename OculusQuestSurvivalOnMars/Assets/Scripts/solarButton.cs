using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Detects if the player has pressed a button on the solar power generator.
*/
public class solarButton : MonoBehaviour
{
	public Material buttonOnNewMaterial;
	public Material buttonOffNewMaterial;
	public AudioSource audioData;
	
	private float activationPositionX = 310.6308f;
		
	private bool finished;
	
	public GameObject buttonOn;
	public GameObject buttonOff;
	
	private GameObject solarMachine;
	
    void Start(){
		solarMachine = GameObject.FindGameObjectWithTag("solarMachine");
	}
	
    void Update(){
		if(!finished){
			if(transform.position.x <= activationPositionX){
				buttonOn.GetComponent<Renderer>().material = buttonOnNewMaterial;
				buttonOff.GetComponent<Renderer>().material = buttonOffNewMaterial;
				audioData.Play();
				solarMachine.GetComponent<solarMachine>().switchActivated();
				finished = true;
			}
		}
	}
}