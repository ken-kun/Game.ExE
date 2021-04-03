using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour {

	[SerializeField] float speed;
	[SerializeField] float lifeSpan;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, lifeSpan);
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward * speed * Time.deltaTime);
		
	}

	private void OnTriggerEnter(Collider other)
	{
		EnemyHealth ehealth;
		BossHealth bHealth;
		if (bHealth = other.GetComponent<BossHealth> ()) {
			bHealth.ChangeHealth (-5);
		}
		else if (ehealth = other.GetComponent<EnemyHealth> ()) {
			ehealth.ChangeHealth(-5);
		}
	}
}
