using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class radiationDiffuser : MonoBehaviour
{
    private float defaultPositionY = 4.589f;
	public Material defaultMaterial;
	public Material newMaterial;
	public AudioSource audioData;
	public AudioSource audioData2;
	public AudioSource audioData3;
	
	private float activationPosition = 4.586f;
	private bool plantPositioned;
	private int nrOfAttemptsToSucceed;
	private int nrOfAttempts;
	
	private bool finished;
	private bool boolAnalyzing;
	
	public GameObject noPlant;
	public GameObject analyzing;
	public GameObject toxic;
	public GameObject edible;
	
	public GameObject radiationSlider;
	
    void Start(){
	}
	
    void Update(){
		
		if(!finished){
			if(!plantPositioned){
				Debug.Log(transform.position.y);
				if(transform.position.y <= activationPosition){
					plantPositioned = true;
					radiationSlider.GetComponent<Slider>().SetValueWithoutNotify(0f);
					GetComponent<Renderer>().material = newMaterial;
				}
			}else{
				if(transform.position.y >= defaultPositionY){
					plantPositioned = false;
					GetComponent<Renderer>().material = defaultMaterial;
				}
			}
		}
	}
	
	private IEnumerator doAnalyzing()
    {
        boolAnalyzing = true;
		noPlant.SetActive(false);
		analyzing.SetActive(true);
		yield return new WaitForSeconds(8f);
		analyzing.SetActive(false);
		if(nrOfAttempts >= nrOfAttemptsToSucceed){
			finished = true;
			edible.SetActive(true);
			audioData3.Play();
		}else{
			toxic.SetActive(true);
			audioData2.Play();
		}
		boolAnalyzing = false;
    }
}
