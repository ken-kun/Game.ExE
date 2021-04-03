using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretDamageScript : MonoBehaviour {
	[SerializeField] AudioSource source;
    [SerializeField] GameObject enemyToDestroy;
    

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Bullet") {
			Debug.Log ("OW");
            
			source.Play ();
            //Destroy(enemyToDestroy);

		}
	}
}
