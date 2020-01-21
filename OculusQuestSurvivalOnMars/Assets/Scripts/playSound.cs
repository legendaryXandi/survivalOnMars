using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSound : MonoBehaviour
{
	public AudioSource audioData;
	private bool alreadyPlayedSound;
	public bool afterPlant;
	public bool afterStone;

    void OnTriggerEnter(){
		if(!alreadyPlayedSound){
			if(afterPlant){
				if(GameObject.FindGameObjectWithTag("player").GetComponent<playerState>().greenHouseFinished){
					audioData.Play();
					alreadyPlayedSound = true;
				}
			}else if(afterStone){
				if(GameObject.FindGameObjectWithTag("player").GetComponent<playerState>().drillingStationFinished){
					Debug.Log("play sound");
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
