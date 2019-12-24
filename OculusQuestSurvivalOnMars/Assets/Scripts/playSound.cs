using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSound : MonoBehaviour
{
	public AudioSource audioData;
	private bool alreadyPlayedSound;

    void OnTriggerEnter(){
		if(!alreadyPlayedSound){
			audioData.Play();
			alreadyPlayedSound = true;
		}
	}
}
