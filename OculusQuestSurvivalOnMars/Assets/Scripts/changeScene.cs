using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class changeScene : MonoBehaviour
{
	private AsyncOperation async;
	public string sceneName;
	public GameObject startButton;
	public GameObject finalButton;
	public GameObject forwardButton;
	private bool intro;
	private int textCount;
	private int count = 0;
	public GameObject[] texts;
	private bool finished;
	public GameObject panel;
	public AudioSource audioData;
	
	public void Start(){
		if(sceneName != "MainMenu"){
			textCount = texts.Length;
		}
	}
	
	
	public void Update(){
		if(intro){
			if(count < textCount){
				if(count == 0){
					panel.GetComponent<Image>().enabled = true;
					texts[count].GetComponent<Text>().enabled = true;
				} else{
					texts[count-1].GetComponent<Text>().enabled = false;
					texts[count].GetComponent<Text>().enabled = true;
				}
			} else{
				texts[count-1].GetComponent<Text>().enabled = false;
				panel.GetComponent<Image>().enabled = false;
				intro = false;
				finished = true;
			}
		} else if(finished){
			forwardButton.SetActive(false);
			finalButton.SetActive(true);
		}
	}

    public void changeToScene(){
		StartCoroutine("loadScene");
	}
	
	IEnumerator loadScene() {
		async = Application.LoadLevelAsync(sceneName);
		if(sceneName == "MainMenu"){
			ActivateScene();
		}else{
			//GetComponentInChildren<Text>().text = "Loading...";
			startButton.SetActive(false);
			forwardButton.SetActive(true);
			audioData.Play();
			intro = true;
			async.allowSceneActivation = false;
		}
		yield return async;
     }
 
     public void ActivateScene() {
         async.allowSceneActivation = true;
     }
	 
	 public void forward(){
		 count++;
	 }
}
