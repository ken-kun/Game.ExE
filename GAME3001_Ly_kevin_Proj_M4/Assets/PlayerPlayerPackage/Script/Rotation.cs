using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

	[SerializeField] Vector3 rotationAxis;
	[SerializeField] float maxRotationAngle = 60;
	[SerializeField] float minRotationAngle = 0;
	float currentAngle = 0;

	// Use this for initialization
	void Start () {
		transform.eulerAngles = rotationAxis * currentAngle;
		
	}
	
	// Update is called once per frame
	public void Rotate (float rotationAngle) {
		float newAngle = currentAngle + rotationAngle;
		if (newAngle >= minRotationAngle && newAngle <= maxRotationAngle) {
			transform.Rotate (rotationAxis * rotationAngle);
			currentAngle = newAngle;
		}
	}
}
