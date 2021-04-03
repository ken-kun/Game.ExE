using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingSystem : MonoBehaviour {

	//Credit to https://forum.unity.com/threads/unity-turret-tutorial.341866/

	public float speed;

	public GameObject m_target;
	Vector3 m_lastKnownPosition = Vector3.zero;
	Quaternion m_lookAtRotation;

	// Update is called once per frame
	void Update () {
		if(m_target){
			
			if(m_lastKnownPosition != m_target.transform.position){
				m_lastKnownPosition = m_target.transform.position;
				m_lookAtRotation = Quaternion.LookRotation(m_lastKnownPosition - transform.position);
			}


		}
	}

	void FixedUpdate() {

		if(transform.rotation != m_lookAtRotation){
			Debug.Log (speed * Time.deltaTime);
			transform.rotation = Quaternion.RotateTowards(transform.rotation, m_lookAtRotation, speed * Time.deltaTime);
		}

	}



}
