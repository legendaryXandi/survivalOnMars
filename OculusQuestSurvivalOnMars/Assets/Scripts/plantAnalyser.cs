using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantAnalyser : MonoBehaviour
{
    
	private float defaultPositionY;
	public Material defaultMaterial;
	public Material newMaterial;
	public AudioSource audioData;
	public AudioSource audioData2;
	public AudioSource audioData3;
	
	private float activationPosition = 5.462f;
	private bool plantPositioned;
	private int nrOfAttemptsToSucceed;
	private int nrOfAttempts;
	
	private bool finished;
	private bool boolAnalyzing;
	
	public GameObject noPlant;
	public GameObject analyzing;
	public GameObject toxic;
	public GameObject edible;
	
	private GameObject[] plants;
	
    void Start(){
		defaultPositionY = transform.position.y - 0.0001f;
		nrOfAttemptsToSucceed = Random.Range(2,5);
		Debug.Log(nrOfAttemptsToSucceed);
		plants = GameObject.FindGameObjectsWithTag("plant");
	}
	
    void Update(){
		if(!finished){
			if(!plantPositioned && !boolAnalyzing){
				if(transform.position.y <= activationPosition){
					plantPositioned = true;
					nrOfAttempts++;
					audioData.Play();
					GetComponent<Renderer>().material = newMaterial;
					StartCoroutine(doAnalyzing());
				}
			}else{
				if(transform.position.y >= defaultPositionY){
					if(boolAnalyzing){
						nrOfAttempts--;
						analyzing.SetActive(false);
					}
					plantPositioned = false;
					noPlant.SetActive(true);
					toxic.SetActive(false);
					edible.SetActive(false);
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
			foreach (GameObject plant in plants){
				plant.GetComponent<pickUpPlant>().setAnalyzed(true);
			}
		}else{
			toxic.SetActive(true);
			audioData2.Play();
		}
		boolAnalyzing = false;
    }
}
