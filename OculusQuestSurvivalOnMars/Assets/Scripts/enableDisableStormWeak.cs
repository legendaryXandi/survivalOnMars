using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
This class enables and disables the weak storm effect. If the player goes outside it starts, if he goes back inside it stops.
*/
public class enableDisableStormWeak : MonoBehaviour
{
	
	private GameObject[] storms;
	private GameObject player;
	
    // Start is called before the first frame update
    void Start()
    {
        storms = GameObject.FindGameObjectsWithTag("sandStormWeak");
		player = GameObject.FindGameObjectWithTag("player");
    }
	
	void OnTriggerEnter(){
		if(player.GetComponent<playerState>().stormIsActivated){
			foreach (GameObject storm in storms){
				storm.GetComponent<ParticleSystem>().Stop();
			}
			player.GetComponent<playerState>().stormIsActivated = false;
		} else{
			foreach (GameObject storm in storms){
				storm.GetComponent<ParticleSystem>().Play();
			}
			player.GetComponent<playerState>().stormIsActivated = true;
		}
	}
}
