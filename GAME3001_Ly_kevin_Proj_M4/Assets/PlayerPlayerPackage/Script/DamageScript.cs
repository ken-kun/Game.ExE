using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DamageScript : MonoBehaviour {
	[SerializeField] AudioSource source;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Laser") {
			source = GetComponent<AudioSource> ();
			source.Play ();
		}
	}
}
