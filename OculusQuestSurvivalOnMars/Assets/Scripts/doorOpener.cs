using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
This script is responsible for opening and closing doors.
*/
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
	private bool moveNow;
	
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
				moveNow = true;
			}			
		}else if(moveNow){
			//open the door
			if(!door.GetComponent<doorState>().isOpen){
				door.transform.Translate(Vector3.up*Time.deltaTime*3);
				if(door.transform.position.y >= 12.45f){
					Debug.Log("should change material");
					door.GetComponent<doorState>().isOpen = true;
					door.GetComponent<doorState>().isMoving = false;
					GetComponent<Renderer>().material = openedMaterial;
					oxygenSlider.GetComponent<Slider>().doorClosed = false;
					radiationSlider.GetComponent<Slider>().doorClosed = false;
					moveNow = false;
				}
			//close the door
			}else{
				door.transform.Translate(Vector3.down*Time.deltaTime*3);
				if(door.transform.position.y <= door.GetComponent<doorState>().defaultPositionY){
					Debug.Log("should change material");
					door.GetComponent<doorState>().isOpen = false;
					door.GetComponent<doorState>().isMoving = false;
					GetComponent<Renderer>().material = closedMaterial;
					oxygenSlider.GetComponent<Slider>().doorClosed = true;
					radiationSlider.GetComponent<Slider>().doorClosed = true;
					moveNow = false;
				}
			}
		}
    }
}
