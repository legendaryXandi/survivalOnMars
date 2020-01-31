using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
This class counts how many stones the player has picked up. If he has picked up 3, the picture in the HUD is complete.
*/
public class stoneCounter : MonoBehaviour
{
	private int counter;
	public GameObject stoneImage1;
	public GameObject stoneImage2;
	public GameObject stoneImage3;
	public GameObject stoneDefault;
	
	public GameObject oldToDo;
	public GameObject newToDo;
	public GameObject highlighter;
	
	public AudioSource audioData;
	
	public void stoneStored(){
		counter++;
		if(counter == 1){
			stoneImage1.SetActive(true);
		}else if(counter == 2){
			stoneImage1.SetActive(false);
			stoneImage2.SetActive(true);
		}else if(counter == 3){
			stoneImage2.SetActive(false);
			stoneDefault.SetActive(false);
			stoneImage3.SetActive(true);
			oldToDo.SetActive(false);
			newToDo.SetActive(true);
			highlighter.SetActive(true);
			audioData.Play();
			GameObject.FindGameObjectWithTag("player").GetComponent<playerState>().drillingStationFinished = true;
		}
	}
}
