using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerScript : MonoBehaviour {

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
		PlayerHealth health;
		if (health = other.GetComponent<PlayerHealth> ()) {
			health.ChangeHealth (-10);
		}
	}
}
