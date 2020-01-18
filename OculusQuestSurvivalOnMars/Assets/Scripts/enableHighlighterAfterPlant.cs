using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableHighlighterAfterPlant : MonoBehaviour
{
	public GameObject highlighterPlant;
	public GameObject highlighterDrilling;
	public bool disable;
	private bool alreadyChangedPlant;
	private bool alreadyChangedDrilling;
	private GameObject player;
	
	void Start(){
		player = GameObject.FindGameObjectWithTag("player");
	}
	
	void OnTriggerEnter(){
		if(!alreadyChangedPlant){
			if(player.GetComponent<playerState>().greenHouseFinished){
				if(!disable){
					highlighterPlant.SetActive(true);
				}else{
					highlighterPlant.SetActive(false);
				}
				alreadyChangedPlant = true;
			}
		}else if(!alreadyChangedDrilling){
			if(player.GetComponent<playerState>().drillingStationFinished){
				if(!disable){
					highlighterDrilling.SetActive(true);
				}else{
					highlighterDrilling.SetActive(false);
				}
				alreadyChangedDrilling = true;
			}
		}
	}
}
