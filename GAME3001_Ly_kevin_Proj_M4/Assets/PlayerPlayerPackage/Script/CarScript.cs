using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour {

	[SerializeField] float movementSpeed = 5;
	[SerializeField] float rotationSpeed = 45;
	[SerializeField] AudioSource source;
	[SerializeField] AudioSource sourceHonk;

	void Update()
	{
		CheckInput ();
	}

	void CheckInput() 
	{
		MoveCar ();
		RotateCar ();
		CarHonk ();

	}

	void MoveCar() {
		if (Input.GetKey (KeyCode.W))
			transform.Translate (Vector3.forward * movementSpeed * Time.deltaTime);
		if (Input.GetKey (KeyCode.S))
			transform.Translate (Vector3.forward * -movementSpeed * Time.deltaTime);

	}

	void CarHonk(){

		if(Input.GetKey(KeyCode.F)){
			//source = GetComponent<AudioSource> ();
			sourceHonk.Play();
		}
			
	}

	void RotateCar() {
		if (Input.GetKey (KeyCode.A))
			transform.Rotate (Vector3.up * -rotationSpeed * Time.deltaTime);
		if (Input.GetKey (KeyCode.D))
			transform.Rotate (Vector3.up * rotationSpeed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Gas") {
			movementSpeed = 10.0f;
		} 

	}

	void OnTriggerExit(Collider other) {
		if (other.gameObject.tag == "Gas") {

			movementSpeed = 20.0f;
	}

    }
}
