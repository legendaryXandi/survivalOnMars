using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickUpPlant : MonoBehaviour
{
	
	private OVRGrabbable ovrGrabbable;
	public Text plantText;
	private bool plantStored;
	public GameObject player;
	Vector3 position;
	Rigidbody rigidbody;
	public GameObject plantImage;
	public GameObject plantDefault;
	
	private bool isAnalyzedPositive;
	private GameObject[] plants;
	
    // Start is called before the first frame update
    void Start()
    {
        ovrGrabbable = GetComponent<OVRGrabbable>();
		position = transform.position;
		rigidbody = GetComponent<Rigidbody>();
		plants = GameObject.FindGameObjectsWithTag("plant");
    }

    // Update is called once per frame
    void Update()
    {
		if(isAnalyzedPositive){
			if(!plantStored && ovrGrabbable.isGrabbed){
				plantText.text = "Press 'A' to store";
				if(OVRInput.Get(OVRInput.Button.One)){
					plantText.text = "";
					plantStored = true;
					//audioData.Play();
					plantImage.SetActive(true);
					plantDefault.SetActive(false);
					GameObject.FindGameObjectWithTag("player").GetComponent<playerState>().greenHouseFinished = true;
				}
			} else if(!plantStored && !ovrGrabbable.isGrabbed){
				plantText.text = "";
			} else if(plantStored){
				foreach (GameObject plant in plants){
					plant.GetComponent<pickUpPlant>().setAnalyzed(false);
				}
				gameObject.SetActive(false);
			}
		}
    }
	
	public void setAnalyzed(bool analyzed){
		isAnalyzedPositive = analyzed;
	}
	
}
