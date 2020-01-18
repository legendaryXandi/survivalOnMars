using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class activateFinishedImage : MonoBehaviour
{
    public bool afterPlant;
	public bool afterStone;
	
	private bool alreadyDone;
	
	private GameObject player;
	
	void Start(){
		player = GameObject.FindGameObjectWithTag("player");
	}
	
	void OnTriggerEnter(){
		if(!alreadyDone){
			if(afterPlant){
				if(player.GetComponent<playerState>().greenHouseFinished){
					GameObject.FindGameObjectWithTag("leafFinished").GetComponent<Image>().enabled = true;
					alreadyDone = true;
				}
			}else if(afterStone){
				if(player.GetComponent<playerState>().drillingStationFinished){
					GameObject.FindGameObjectWithTag("stoneFinished").GetComponent<Image>().enabled = true;
					alreadyDone = true;
				}
			}
		}
	}
}
