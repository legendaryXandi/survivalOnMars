using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
Let's the player decrease his radiation level once.
*/
public class radiationDiffuser : MonoBehaviour
{
    private float defaultPositionY;
	private float defaultPositionX;
	public Material defaultMaterial;
	public Material newMaterial;
	public AudioSource audioData;
	public AudioSource audioData2;
	public AudioSource audioData3;
	
	private float activationPositionY;
	private float activationPositionX;
	private bool plantPositioned;
	private int nrOfAttemptsToSucceed;
	private int nrOfAttempts;
	
	private bool finished;
	private bool pushed;
	
	public GameObject defuser;
	public GameObject defusing;
	public GameObject defused;
	public GameObject edible;
	
	public GameObject steam;
	private ParticleSystem particleSystem;
	public GameObject radiationSlider;
	private float currentValue;
	
    void Start(){
		particleSystem = steam.GetComponent(typeof(ParticleSystem)) as ParticleSystem;
		defaultPositionX = transform.position.x;
		defaultPositionY = transform.position.y;
	}
	
    void Update(){
		if(!finished){
			if(!pushed && transform.position.x <= defaultPositionX - 0.005f && transform.position.y <= defaultPositionY - 0.005f){
				particleSystem.Play();
				audioData.Play();
				pushed = true;
				radiationSlider.GetComponent<Slider>().radiationIncrease = -5f;
				defuser.SetActive(false);
				defusing.SetActive(true);
			}
			
			if(pushed && currentValue <= 0.001f){
				particleSystem.Stop();
				radiationSlider.GetComponent<Slider>().radiationIncrease = 0.35f;
				finished = true;
				defusing.SetActive(false);
				defused.SetActive(true);
				audioData2.Play();
				audioData3.Play();
			}
		}
	}
	
	public void OnValueChanged(float newValue)
	{
		currentValue = newValue;
	}
}
