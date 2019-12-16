using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpWalki : MonoBehaviour
{
	
	private OVRGrabbable ovrGrabbable;
	private OVRInput.Button buttonA;
	public GameObject text;
	
    // Start is called before the first frame update
    void Start()
    {
        ovrGrabbable = GetComponent<OVRGrabbable>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ovrGrabbable.isGrabbed){
			text.SetActive(true);
		}
    }
}
