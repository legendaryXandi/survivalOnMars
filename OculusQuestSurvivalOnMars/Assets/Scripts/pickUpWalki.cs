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
	public AudioSource audioData;
	Vector3 position;
	Rigidbody rigidbody;
	public GameObject walkieImage;
	
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
				audioData.Play();
				walkieImage.SetActive(true);
			}
		} else if(!walkiStored && !ovrGrabbable.isGrabbed){
			walkiText.text = "Pick me up!";
		} else if(walkiStored){
			/*position.x = player.transform.position.x;
			position.y = player.transform.position.y;
			position.z = player.transform.position.z;
			transform.position = position;
			transform.parent = player.transform;
			rigidbody.isKinematic = true;*/
			gameObject.GetComponent<Renderer>().enabled=false;
		}
    }
}
