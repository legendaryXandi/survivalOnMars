using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enableDisableTodo : MonoBehaviour
{
    
	public GameObject oldToDo;
	public GameObject newToDo;
	private AudioSource nextToDoSound;
	
	public bool afterPlant;
	public bool afterStone;
	
	private bool alreadyChanged;
	
	void Start(){
		nextToDoSound = GameObject.FindGameObjectWithTag("nextToDoSound").GetComponent<AudioSource>();
	}
	
	void OnTriggerEnter(){
		if(!alreadyChanged){
			if(afterPlant){
				if(GameObject.FindGameObjectWithTag("player").GetComponent<playerState>().greenHouseFinished){
					oldToDo.SetActive(false);
					newToDo.SetActive(true);
					alreadyChanged = true;
					nextToDoSound.Play();
				}
			}else if(afterStone){
				if(GameObject.FindGameObjectWithTag("player").GetComponent<playerState>().drillingStationFinished){
					oldToDo.SetActive(false);
					newToDo.SetActive(true);
					alreadyChanged = true;
					nextToDoSound.Play();
				}
			}else{
				oldToDo.SetActive(false);
				newToDo.SetActive(true);
				alreadyChanged = true;
				nextToDoSound.Play();
			}
		}
	}
}
