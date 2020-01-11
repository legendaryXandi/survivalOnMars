using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableDisableStormWeak : MonoBehaviour
{
	
	private GameObject[] storms;
	public bool stormIsActivated;
	
    // Start is called before the first frame update
    void Start()
    {
        storms = GameObject.FindGameObjectsWithTag("sandStormWeak");
    }
	
	void OnTriggerEnter(){
		if(stormIsActivated){
			foreach (GameObject storm in storms){
				storm.GetComponent<ParticleSystem>().Stop();
			}
			stormIsActivated = false;
		} else{
			foreach (GameObject storm in storms){
				storm.GetComponent<ParticleSystem>().Play();
			}
			stormIsActivated = true;
		}
	}
}
