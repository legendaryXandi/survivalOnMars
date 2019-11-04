using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour
{
    public GameObject door;
	public AudioSource audioSourceLift;
	public AudioSource audioSourceWind;
	public AudioSource audioSourceButton;
	private bool audioPlayed = false;
	private bool shouldMove = false;
	private float maxTranslation = 5f;
	private float alreadyTranslated = 0f;
	
	void Update(){
		if(shouldMove && alreadyTranslated < maxTranslation){
			door.transform.Translate(0,0.015f,0);
			alreadyTranslated += 0.015f;
			if(!audioPlayed){
				audioSourceButton.Play(0);
				audioSourceLift.Play(1);
				audioSourceWind.Play(4);
				audioPlayed = true;
			}
		} else{
			door.transform.Translate(0,0,0);
		}
	}
	
	public void activateMovement(){
		shouldMove = !shouldMove;
	}
}
