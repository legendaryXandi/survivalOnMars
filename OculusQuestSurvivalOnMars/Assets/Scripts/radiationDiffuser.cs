using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class radiationDiffuser : MonoBehaviour
{
    private float defaultPositionY = 6.158f;
	private float defaultPositionX = 431.612f;
	public Material defaultMaterial;
	public Material newMaterial;
	public AudioSource audioData;
	public AudioSource audioData2;
	public AudioSource audioData3;
	
	private float activationPositionY = 6.157f;
	private float activationPositionX = 431.608f;
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
	}
	
    void Update(){
		if(!finished){
			if(!pushed && transform.position.x <= activationPositionX && transform.position.y <= activationPositionY){
				particleSystem.Play();
				audioData.Play();
				pushed = true;
				radiationSlider.GetComponent<Slider>().radiationIncrease = -2f;
				defuser.SetActive(false);
				defusing.SetActive(true);
			}
			
			if(pushed && currentValue <= 0.001f){
				particleSystem.Stop();
				radiationSlider.GetComponent<Slider>().radiationIncrease = 0.35f;
				finished = true;
				defusing.SetActive(false);
				defused.SetActive(true);
			}
		}
	}
	
	public void OnValueChanged(float newValue)
	{
		currentValue = newValue;
	}
}
