using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverGrabbable : OVRGrabbable
{
    
	public Transform transformHandler;
	
	public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity){
		base.GrabEnd(Vector3.zero, Vector3.zero);
		transform.position = transformHandler.transform.position;
		transform.rotation = transformHandler.transform.rotation;
	}
}
