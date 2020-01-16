using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class doorOpener : MonoBehaviour
{
    public GameObject door;
	
	public AudioSource audioData;
	public AudioSource audioData2;
	public bool isReverse;
	
	private float defaultPositionZ;
	public Material closedMaterial;
	public Material openedMaterial;
	
	public GameObject oxygenSlider;
	public GameObject radiationSlider;
	
	void Start(){
		defaultPositionZ = transform.position.z;
	}
    // Update is called once per frame
    void Update()
    {
		if(!door.GetComponent<doorState>().isMoving){
			if(transform.position.z <= defaultPositionZ - 0.008f || (isReverse && transform.position.z >= defaultPositionZ + 0.008f)){
				audioData.Play();
				audioData2.Play();
				door.GetComponent<doorState>().isMoving = true;
			}			
		}else{
			if(!door.GetComponent<doorState>().isOpen){
				door.transform.Translate(Vector3.up*Time.deltaTime*3);
				if(door.transform.position.y >= 12.45f){
					door.GetComponent<doorState>().isOpen = true;
					door.GetComponent<doorState>().isMoving = false;
				}
			}else{
				door.transform.Translate(Vector3.down*Time.deltaTime*3);
				if(door.transform.position.y <= door.GetComponent<doorState>().defaultPositionY){
					door.GetComponent<doorState>().isOpen = false;
					door.GetComponent<doorState>().isMoving = false;
				}
			}
		}
		if(!door.GetComponent<doorState>().isOpen){
			GetComponent<Renderer>().material = closedMaterial;
			oxygenSlider.GetComponent<Slider>().doorClosed = true;
			radiationSlider.GetComponent<Slider>().doorClosed = true;
		}else{
			GetComponent<Renderer>().material = openedMaterial;
			oxygenSlider.GetComponent<Slider>().doorClosed = false;
			radiationSlider.GetComponent<Slider>().doorClosed = true;
		}
    }
}
