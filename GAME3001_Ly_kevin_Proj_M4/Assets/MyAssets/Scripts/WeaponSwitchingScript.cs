using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitchingScript : MonoBehaviour {

    [SerializeField] GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("e"))
        {
            player.GetComponent<TurretScript>().enabled = true;
            player.GetComponent<LazerBeamScript>().enabled = false;
            player.GetComponent<LineRenderer>().enabled =false;
        }
        else if (Input.GetKeyDown("r"))
        {
            player.GetComponent<LazerBeamScript>().enabled = true;
            player.GetComponent<TurretScript>().enabled = false;
            player.GetComponent<LineRenderer>().enabled = true;
        }
        else if (Input.GetKeyDown("t"))
        {

        }
	}
}
