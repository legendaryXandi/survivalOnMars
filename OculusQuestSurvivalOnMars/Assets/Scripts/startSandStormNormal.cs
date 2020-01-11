using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startSandStormNormal : MonoBehaviour
{
	
	public GameObject[] storms;
	
    // Start is called before the first frame update
	void Start(){
		storms = GameObject.FindGameObjectsWithTag("sandStormWeak");
		foreach (GameObject storm in storms){
			storm.GetComponent<ParticleSystem>().Play();
		}
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
