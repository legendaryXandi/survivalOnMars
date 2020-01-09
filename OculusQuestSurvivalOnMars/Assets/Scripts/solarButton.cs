using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solarButton : MonoBehaviour
{
	private float defaultPositionY = 6.158f;
	private float defaultPositionX = 431.612f;
	public Material defaultMaterial;
	public Material buttonOnNewMaterial;
	public Material buttonOffNewMaterial;
	public AudioSource audioData;
	public AudioSource audioData2;
	public AudioSource audioData3;
	
	private float activationPositionY = 6.157f;
	private float activationPositionX = 310.6280f;
	private bool plantPositioned;
	private int nrOfAttemptsToSucceed;
	private int nrOfAttempts;
	
	private bool finished;
	private bool pushed;
	
	public GameObject noPlant;
	public GameObject analyzing;
	public GameObject toxic;
	public GameObject edible;
	
	public GameObject steam;
	private ParticleSystem particleSystem;
	public GameObject radiationSlider;
	private float currentValue;
	
	public GameObject buttonOn;
	public GameObject buttonOff;
	
    void Start(){

	}
	
    void Update(){
		Debug.Log(transform.position.x);
		if(!finished){
			if(transform.position.x <= activationPositionX){
				buttonOn.GetComponent<Renderer>().material = buttonOnNewMaterial;
				buttonOff.GetComponent<Renderer>().material = buttonOffNewMaterial;
				audioData.Play();
				finished = true;
			}
		}
	}
}