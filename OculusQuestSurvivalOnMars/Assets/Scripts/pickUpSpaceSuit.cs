using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickUpSpaceSuit : MonoBehaviour
{
 	
	private OVRGrabbable ovrGrabbable;
	public Text plantText;
	private bool plantStored;
	public GameObject plantImage;
	public AudioSource audioData;
	public AudioSource audioData2;
	
    // Start is called before the first frame update
    void Start()
    {
        ovrGrabbable = GetComponent<OVRGrabbable>();
    }

    // Update is called once per frame
    void Update()
    {
		if(!plantStored && ovrGrabbable.isGrabbed){
			plantText.text = "Press 'A' to store";
			if(OVRInput.Get(OVRInput.Button.One)){
				plantText.text = "";
				plantStored = true;
				audioData.Play();
				audioData2.Play();
			}
		} else if(!plantStored && !ovrGrabbable.isGrabbed){
			plantText.text = "Pick me up!";
		} else if(plantStored){
			gameObject.SetActive(false);
		}
    }
}
