﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public GameObject player;
	
	public void teleportPlayer(){
		player.transform.position = new Vector3(transform.position.x, transform.position.y - 1.0f, transform.position.z);
	}
}
