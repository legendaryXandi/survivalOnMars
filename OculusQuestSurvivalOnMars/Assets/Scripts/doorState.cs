using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorState : MonoBehaviour
{
	
	public bool isOpen;
	public bool isMoving;
	
	public float defaultPositionY;

	void Start(){
		defaultPositionY = transform.position.y;
	}

}
