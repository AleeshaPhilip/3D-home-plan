using UnityEngine;
using System.Collections;

public class Rotater : MonoBehaviour {

	public GameObject  objectRotate;

	public float	   rotateSpeed = 50f;
	bool			   rotateStatus = false;

	public void Rotasi() {

		if (rotateStatus==false){
			rotateStatus = true;
		}
		else{
			rotateStatus = false;
		}
	}

	void Update() {
		if (rotateStatus == true) {
			objectRotate.transform.Rotate (Vector3.down, rotateSpeed * Time.deltaTime);
		}
	}
} 

