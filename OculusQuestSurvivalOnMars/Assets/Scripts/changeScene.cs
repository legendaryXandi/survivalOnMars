using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class changeScene : MonoBehaviour
{
	public string sceneName;

    public void changeToScene(){
		SceneManager.LoadSceneAsync(sceneName);
		GetComponentInChildren<Text>().text = "Loading...";
	}
}
