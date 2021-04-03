using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineScritpt : MonoBehaviour {

	[SerializeField] GameObject explosionPrefab;


	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		

		if(other.tag == "Car") {
			PlayerHealth health = other.transform.root.GetComponent<PlayerHealth> ();
			health.ChangeHealth (-10);



			Debug.Log ("BOOM");
			Destroy (gameObject);
			GameObject explosionInst = Instantiate (explosionPrefab, transform.position, transform.rotation) as GameObject;

		}


	}
}

