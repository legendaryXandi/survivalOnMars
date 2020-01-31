using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
This class activates the sand storm.
*/
public class activateSandStorm : MonoBehaviour
{
	
	public AudioSource audioData;
	private int oneSecond = 1;
	private float time;
	private bool fogDensityReached;
	private bool alreadyPlayedSound;
	private bool enteredTrigger;
	private GameObject[] storms;
	private int stormCount;
	private int count = 0;
	
	void Start(){
		storms = GameObject.FindGameObjectsWithTag("sandStormStrong");
		stormCount = storms.Length;
	}
	
	/*
	increase fog density over time.
	*/
	void Update(){
		if(enteredTrigger && !fogDensityReached){
			time += Time.deltaTime;
		 
			if (time >= oneSecond){
				time = 0f;
				increaseFogDensity();
				
				if(count < stormCount){
					storms[count].GetComponent<ParticleSystem>().Play();
					count++;
				}
			}
		}
	}
	
	/*
	give signal to start with sandstorm
	*/
    void OnTriggerEnter(){
		if(!alreadyPlayedSound && GameObject.FindGameObjectWithTag("player").GetComponent<playerState>().powerFinished){
			audioData.Play();
			alreadyPlayedSound = true;
			enteredTrigger = true;
		}
	}
	
	void increaseFogDensity(){
		RenderSettings.fogDensity = RenderSettings.fogDensity + 0.007f;
		if(RenderSettings.fogDensity >= 0.5f){
			fogDensityReached = true;
		}
	}
	
}