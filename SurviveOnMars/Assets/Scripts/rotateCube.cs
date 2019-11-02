using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCube : MonoBehaviour
{
	public float spinForce;
	private bool isSpinning = false;

    // Update is called once per frame
    void Update()
    {
		if(isSpinning){
			transform.Rotate(0,spinForce * Time.deltaTime,0);
		} else{
			transform.Rotate(0,0,0);
		}
    }
	
	public void changeSpin(){
		isSpinning = !isSpinning;
	}
}
