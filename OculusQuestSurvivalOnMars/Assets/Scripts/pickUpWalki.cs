using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickUpWalki : MonoBehaviour
{
	
	private OVRGrabbable ovrGrabbable;
	public Text walkiText;
	private bool walkiStored;
	public GameObject player;
	Vector3 position;
	Rigidbody rigidbody;
	
    // Start is called before the first frame update
    void Start()
    {
        ovrGrabbable = GetComponent<OVRGrabbable>();
		position = transform.position;
		rigidbody = GetComponent<Rigidbody>();
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
		} else if(walkiStored){
			position.x = player.transform.position.x;
			position.y = player.transform.position.y + 0.3f;
			position.z = player.transform.position.z - 0.3f;
			transform.position = position;
			transform.parent = player.transform;
			rigidbody.isKinematic = true;
		}
    }
}
