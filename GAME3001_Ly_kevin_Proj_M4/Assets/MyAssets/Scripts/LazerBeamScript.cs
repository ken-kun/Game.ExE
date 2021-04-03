using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerBeamScript : MonoBehaviour {

    LineRenderer line;
    [SerializeField] GameObject enemy;

	// Use this for initialization
	void Start () {
        line = gameObject.GetComponent<LineRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        
        RaycastHit hit;
        float range = 1000;
        if (Physics.Raycast(transform.position, transform.position + transform.forward * range, out hit))
        {
            if (hit.transform.tag == "enemy")
            {
                Destroy(hit.transform.gameObject);
                //EnemyHealth--;
            }
            Vector3[] positionz = new Vector3[] { transform.position, hit.point };
            line.SetPositions(positionz);
        }
        else
        {
            Vector3[] positionz = new Vector3[] { transform.position, transform.position + transform.forward * range };
            line.SetPositions(positionz);
        }

    }

    
}
