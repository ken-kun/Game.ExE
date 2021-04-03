using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoFireScript : MonoBehaviour {


	[SerializeField] GameObject projectilePrefab;
	[SerializeField] Transform projectileSpawn1;
	[SerializeField] Transform projectileSpawn2;
	[SerializeField] Transform projectileSpawn3;
	[SerializeField] Transform projectileSpawn4;
	[SerializeField] GameObject player;
	
	bool FireRate = true;


	
	// Update is called once per frame
	void Update () {


		FireInput ();
		
	}

    private void Start()
    {
        
    }

    void FireInput () {

		Vector3 direction = transform.position - player.transform.position;

		if (FireRate == true && direction.magnitude <= 50.0f ) {
			FireRate = false;
			Instantiate (projectilePrefab, projectileSpawn1.position, projectileSpawn1.rotation);
			Instantiate (projectilePrefab, projectileSpawn2.position, projectileSpawn2.rotation);
			Instantiate (projectilePrefab, projectileSpawn3.position, projectileSpawn3.rotation);
			Instantiate (projectilePrefab, projectileSpawn4.position, projectileSpawn4.rotation);
			Invoke ("Delay", 0.2f);
		}

	}

	void Delay() {
		FireRate = true;
	}
}
