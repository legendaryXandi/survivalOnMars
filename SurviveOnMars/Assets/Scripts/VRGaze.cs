﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRGaze : MonoBehaviour
{
	
	public Image imgGaze;
	public float totalTime = 2;
	bool gvrStatus;
	float gvrTimer;
	
	public int distanceOfRay = 100;
	private RaycastHit _hit;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gvrStatus){
			gvrTimer += Time.deltaTime;
			imgGaze.fillAmount = gvrTimer / totalTime;
		}
		
		Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
		if(Physics.Raycast(ray,out _hit, distanceOfRay)){
			if(imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Teleport")){
							Debug.Log("invoking teleporting");
				_hit.transform.gameObject.GetComponent<teleport>().teleportPlayer();
			} else if(imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Rotate") && gvrStatus){
				_hit.transform.gameObject.GetComponent<rotateCube>().changeSpin();
				gvrStatus = false;
			} else if(imgGaze.fillAmount == 1 && _hit.transform.CompareTag("OpenDoor") && gvrStatus){
				_hit.transform.gameObject.GetComponent<openDoor>().activateMovement();
				gvrStatus = false;
			} else if(imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Respawn") && gvrStatus){
				_hit.transform.gameObject.GetComponent<respawn>().backToMainMenu();
				gvrStatus = false;
			}
		}
    }
	
	public void GVROn(){
		gvrStatus = true;
	}
	
	public void GVROff(){
		gvrStatus = false;
		gvrTimer = 0;
		imgGaze.fillAmount = 0;
	}
}
