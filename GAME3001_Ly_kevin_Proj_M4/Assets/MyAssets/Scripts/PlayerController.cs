using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	[SerializeField] private float moveSpeed = 10f;
	[SerializeField] private float rotSpeed = 10f;
    [SerializeField] Camera mainCamera;
	
	// Update is called once per frame
	void Update () {
		Vector3 offset = Vector3.zero;
		if (Input.GetKey("s"))
		{
			offset += Vector3.forward;
		}
		if (Input.GetKey("w"))
		{
			offset += Vector3.back;
		}
		if (Input.GetKey("d"))
		{
			offset += Vector3.left;
		}
		if (Input.GetKey("a"))
		{
			offset += Vector3.right;
		}
		offset = Vector3.Normalize(offset) * moveSpeed * Time.deltaTime;
		transform.Translate(offset, Space.World);
        Vector3 mousePosition;
        

            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
            
                mousePosition = hit.point;
                Vector3 dir = mousePosition - transform.position;
            Quaternion rotDir = Quaternion.LookRotation(dir);
			transform.rotation = Quaternion.RotateTowards( transform.rotation, rotDir, rotSpeed * Time.deltaTime );
            transform.eulerAngles = new Vector3(0, transform.rotation.eulerAngles.y, 0);

            }





		
	}
}
