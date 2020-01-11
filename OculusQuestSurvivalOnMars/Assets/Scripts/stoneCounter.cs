using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stoneCounter : MonoBehaviour
{
	private int counter;
	public GameObject stoneImage1;
	public GameObject stoneImage2;
	public GameObject stoneImage3;
	
	public void stoneStored(){
		counter++;
		if(counter == 1){
			stoneImage1.SetActive(true);
		}else if(counter == 2){
			stoneImage1.SetActive(false);
			stoneImage2.SetActive(true);
		}else if(counter == 3){
			stoneImage2.SetActive(false);
			stoneImage3.SetActive(true);
		}
	}
}
