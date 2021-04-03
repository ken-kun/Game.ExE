using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapScript : MonoBehaviour {

	[SerializeField] Color debugColor;
	[SerializeField] Vector3 size;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void OnDrawGizmos (){

		debugColor = Color.blue;
		debugColor.a = 0.3f;
		Gizmos.color = debugColor;
		Gizmos.DrawCube (transform.position, size);
	}
}
