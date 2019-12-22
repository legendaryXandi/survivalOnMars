using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class labOpener : MonoBehaviour
{
	public GameObject door;
	private bool isOpen;
	private bool doorIsOpening;
	public AudioSource audioData;
	public AudioSource audioData2;
	
	void Update(){
		Debug.Log(door.transform.position.x);
		if(!isOpen){
			if(!doorIsOpening && transform.position.z > 777.3200f){
				audioData.Play();
				audioData2.Play();
				doorIsOpening = true;
			}
			if(doorIsOpening){
				door.transform.Translate(Vector3.forward*Time.deltaTime*3);
				
			}
			if(door.transform.position.x > 437.58f){
				isOpen = true;
			}
		}
	}
}
