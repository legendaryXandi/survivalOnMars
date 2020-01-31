﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
This class enables or disables highlighter for the better user experience of the player.
*/
public class enableDisableHighlighter : MonoBehaviour
{
    public GameObject oldHighlighter;
	public GameObject newHighlighter;
	private bool alreadyChanged;
	public bool onlyDisable;
	public bool onlyEnable;
	
	void OnTriggerEnter(){
		if(!alreadyChanged){
			if(onlyDisable){
				oldHighlighter.SetActive(false);
			}else if(onlyEnable){
				newHighlighter.SetActive(true);
			}else{
				oldHighlighter.SetActive(false);
				newHighlighter.SetActive(true);
			}
			alreadyChanged = true;
		}
	}
}
