using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickUpWalki : MonoBehaviour
{
	
	private OVRGrabbable ovrGrabbable;
	public Text walkiText;
	private bool walkiStored;
	
    // Start is called before the first frame update
    void Start()
    {
        ovrGrabbable = GetComponent<OVRGrabbable>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!walkiStored && ovrGrabbable.isGrabbed){
			walkiText.text = "Press 'A' to store";
			if(OVRInput.Get(OVRInput.Button.One)){
				walkiText.text = "";
				walkiStored = true;
			}
		} else if(!walkiStored && !ovrGrabbable.isGrabbed){
			walkiText.text = "Pick me up!";
		}
    }
}
