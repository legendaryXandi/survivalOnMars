using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSound : MonoBehaviour
{
	public AudioSource audioData;
	private bool alreadyPlayedSound;
	public bool afterPlant;

    void OnTriggerEnter(){
		if(!alreadyPlayedSound){
			if(afterPlant){
				if(GameObject.FindGameObjectWithTag("player").GetComponent<playerState>().greenHouseFinished){
					audioData.Play();
					alreadyPlayedSound = true;
				}
			}else{
				audioData.Play();
				alreadyPlayedSound = true;
			}
		}
	}
}
