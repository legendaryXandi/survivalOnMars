using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
