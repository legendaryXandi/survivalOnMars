using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
This class holds the state of a door. (Wether it's closed or not, and is currently moving or not)
*/
public class doorState : MonoBehaviour
{
	
	public bool isOpen;
	public bool isMoving;
	
	public float defaultPositionY;

	void Start(){
		defaultPositionY = transform.position.y;
	}

}
