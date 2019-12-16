using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpener : MonoBehaviour
{
    public GameObject door;
	private bool doorIsOpening;
	private bool doorHasBeenOpened;
	
	public AudioSource audioData;

    // Update is called once per frame
    void Update()
    {
		if(!doorHasBeenOpened){
			if(transform.position.y < 5.75f && !doorIsOpening){
				doorIsOpening = true;
				audioData.Play(2);
			}
			if(doorIsOpening){
				door.transform.Translate(Vector3.up*Time.deltaTime*3);
			}
			if(door.transform.position.y > 12.45f){
				doorHasBeenOpened = true;
			}
		}
    }
}
