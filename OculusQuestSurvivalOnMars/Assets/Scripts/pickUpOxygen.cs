using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickUpOxygen : MonoBehaviour
{
    private OVRGrabbable ovrGrabbable;
	public Text plantText;
	private bool plantStored;
	public GameObject plantImage;
	public AudioSource audioData;
	public AudioSource audioData2;
	public GameObject oxygenSlider;
	
	public GameObject oldToDo;
	public GameObject newToDo;
	
    // Start is called before the first frame update
    void Start()
    {
        ovrGrabbable = GetComponent<OVRGrabbable>();
    }

    // Update is called once per frame
    void Update()
    {
		if(!plantStored && ovrGrabbable.isGrabbed){
			plantText.text = "Press 'A' to refill oxygen";
			if(OVRInput.Get(OVRInput.Button.One)){
				plantText.text = "";
				plantStored = true;
				oxygenSlider.GetComponent<Slider>().value = 100f;
			}
		} else if(!plantStored && !ovrGrabbable.isGrabbed){
			plantText.text = "";
		} else if(plantStored){
			gameObject.SetActive(false);
		}
    }
}
