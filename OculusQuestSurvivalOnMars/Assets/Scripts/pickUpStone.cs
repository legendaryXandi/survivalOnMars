using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
Let's the player pick up the stone and store it.
*/
public class pickUpStone : MonoBehaviour
{	
	private OVRGrabbable ovrGrabbable;
	public Text plantText;
	private bool plantStored;
	public GameObject player;
	Vector3 position;
	Rigidbody rigidbody;
	public GameObject plantImage;
	private GameObject HUD;
	
	private bool isAnalyzedPositive;
	private GameObject[] plants;
	
    // Start is called before the first frame update
    void Start()
    {
        ovrGrabbable = GetComponent<OVRGrabbable>();
		HUD = GameObject.FindGameObjectWithTag("HUDRight");
    }

    // Update is called once per frame
    void Update()
    {
		if(!plantStored && ovrGrabbable.isGrabbed){
			plantText.text = "Press 'A' to store";
			if(OVRInput.Get(OVRInput.Button.One)){
				plantText.text = "";
				plantStored = true;
				HUD.GetComponent<stoneCounter>().stoneStored();
			}
		} else if(!plantStored && !ovrGrabbable.isGrabbed){
			plantText.text = "";
		} else if(plantStored){
			gameObject.SetActive(false);
		}
    }
	
}
