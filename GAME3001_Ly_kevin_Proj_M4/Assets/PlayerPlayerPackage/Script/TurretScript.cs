using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour {

	[SerializeField] Rotation turretRotation;
	[SerializeField] Rotation barrelRotation;
	[SerializeField] GameObject projectilePrefab;
	[SerializeField] Transform projectileSpawn;
	[SerializeField] float rotationSpeed = 45;
	bool FireRate = true;
	[SerializeField] AudioSource source;



	void Update()
	{
		CheckInput ();
	}

	void CheckInput() 
	{
		
		RotateTurret ();
		RotateBarrel ();
		FireInput ();
	}




	void RotateTurret() {

		if (Input.GetKey (KeyCode.RightArrow))
			turretRotation.Rotate (rotationSpeed * Time.deltaTime);
		if (Input.GetKey (KeyCode.LeftArrow))
			turretRotation.Rotate (-rotationSpeed * Time.deltaTime);
	}

	void RotateBarrel() {

		if (Input.GetKey (KeyCode.UpArrow))
			barrelRotation.Rotate (-rotationSpeed * Time.deltaTime);
		if (Input.GetKey (KeyCode.DownArrow))
			barrelRotation.Rotate (rotationSpeed * Time.deltaTime);
	}

	void FireInput () {

		if (Input.GetMouseButtonDown(0) && FireRate == true ) {
			source = GetComponent<AudioSource> ();
			source.Play ();
			FireRate = false;
			Instantiate (projectilePrefab, projectileSpawn.position, projectileSpawn.rotation);
			Debug.Log (projectileSpawn.gameObject.name);
			Invoke ("Delay", 0.5f);
		}

	}

	void Delay() {
		FireRate = true;
	}
}
