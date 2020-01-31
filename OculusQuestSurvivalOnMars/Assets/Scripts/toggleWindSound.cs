using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
This class toggles the wind sound. If the player walks outside the sound starts, if he gets back inside, the sound stops.
*/
public class toggleWindSound : MonoBehaviour
{
    
	void OnTriggerEnter(){
		if(GameObject.FindGameObjectWithTag("windSound").GetComponent<AudioSource>().isPlaying){
			GameObject.FindGameObjectWithTag("windSound").GetComponent<AudioSource>().Stop();
		}else{
			GameObject.FindGameObjectWithTag("windSound").GetComponent<AudioSource>().Play();
		}
	}
}
