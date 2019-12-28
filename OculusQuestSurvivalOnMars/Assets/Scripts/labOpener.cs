using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class labOpener : MonoBehaviour
{
	public GameObject door;
	private bool isFinished;
	private bool doorIsMoving;
	public AudioSource audioData;
	public AudioSource audioData2;
	private float buttonActivationPosition;
	private float stopDoorPosition;
	private float defaultDoorPosition;
	
	public Material defaultMaterial;
	public Material newMaterial;
	
	void Start(){
		if(CompareTag("doorLab")){
			buttonActivationPosition = 777.3200f;
			defaultDoorPosition = door.transform.position.x;
			stopDoorPosition = 437.58f;
		}else if(CompareTag("doorOutside")){
			buttonActivationPosition = 761.2600f;
			stopDoorPosition = 12f;
		}else if(CompareTag("doorOutsideCloser")){
			buttonActivationPosition = 763.3900f;
			defaultDoorPosition = 12f;
			stopDoorPosition = 6.68347f;
		}
	}
	
	void Update(){		
		if(!isFinished){
			if(!doorIsMoving){
				if(CompareTag("doorOutsideCloser")){
					if(transform.position.z < buttonActivationPosition){
						doorIsMoving = true;
					}
				} else{
					if(transform.position.z > buttonActivationPosition){
						doorIsMoving = true;
					}
				}
				if(doorIsMoving){
					audioData.Play();
					audioData2.Play();
					GetComponent<Renderer>().material = newMaterial;
				}			
			}
			if(doorIsMoving){
				if(CompareTag("doorLab")){
					door.transform.Translate(Vector3.forward*Time.deltaTime*2);
				} else if(CompareTag("doorOutside")){
					door.transform.Translate(Vector3.up*Time.deltaTime*2);
				} else if(CompareTag("doorOutsideCloser")){
					door.transform.Translate(Vector3.down*Time.deltaTime*2);
				}
				
				if(CompareTag("doorLab")){
					if(door.transform.position.x >= stopDoorPosition){
						isFinished = true;
						doorIsMoving = false;
					}
				} else if(CompareTag("doorOutside")){
					if(door.transform.position.y >= stopDoorPosition){
						isFinished = true;
						doorIsMoving = false;
					}
				} else if(CompareTag("doorOutsideCloser")){
					if(door.transform.position.y <= stopDoorPosition){
						isFinished = true;
						doorIsMoving = false;
					}
				}
			}
		}else if(CompareTag("doorLab")){
			if(!doorIsMoving){
				if(transform.position.z > buttonActivationPosition){
					doorIsMoving = true;
					audioData.Play();
					audioData2.Play();
					GetComponent<Renderer>().material = defaultMaterial;
				}
			}
			if(doorIsMoving){
				door.transform.Translate(Vector3.back*Time.deltaTime*2);
				if(door.transform.position.x <= defaultDoorPosition){
					isFinished = false;
					doorIsMoving = false;
				}
			}
		}else if(CompareTag("doorOutsideCloser")){
			if(!doorIsMoving){
				if(transform.position.z < buttonActivationPosition){
					doorIsMoving = true;
					audioData.Play();
					audioData2.Play();
					GetComponent<Renderer>().material = defaultMaterial;
				}
			}
			if(doorIsMoving){
				door.transform.Translate(Vector3.up*Time.deltaTime*2);
				if(door.transform.position.y >= defaultDoorPosition){
					isFinished = false;
					doorIsMoving = false;
				}
			}
		}
	}
}
