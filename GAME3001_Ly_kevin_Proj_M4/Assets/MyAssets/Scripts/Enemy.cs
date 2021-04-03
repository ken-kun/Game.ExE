using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {

	private Animator anim;

	 public Transform targetObj;
	[SerializeField] private float moveSpeed = 0;
    [SerializeField] private float wanderSpeed = 0;
	[SerializeField] private float rotSpeed = 0;
	[SerializeField] private float slowDist = 0; 
	[SerializeField] private float stopDist = 0;
    [SerializeField] private float seekDist = 0;

	private bool isMoving; // This flag controls whether or not the actor is moving. Set false when arrived.
    private bool isWandering; //cpmtrols wheather actor is wondering 
	private Vector3 destVect; // Direction to target. Calculated each frame in Update.
	private Quaternion destRot; // Desired rotation to target. Calculated each frame in Update.
	private float distTo; // Distance to target. Calculated each frame in Update.

	void Start()
	{
		//anim = GetComponent<Animator>();
		SetMoving(true);
        SetWandering(true);
        GetNewDest();

        targetObj = GameObject.Find("Player").transform;
	}

	void Update () {
        ///calculations
		destVect = targetObj.position - transform.position;
		
		distTo = Vector3.Distance(transform.position, targetObj.position);

        GetComponent<NavMeshAgent>().SetDestination(targetObj.position);
        

        
		if (isMoving) { 

            if (isWandering)
            {
                transform.rotation = Quaternion.RotateTowards(transform.rotation, destRot, rotSpeed * Time.deltaTime);
                if (transform.rotation == destRot)
                {
                    GetNewDest();
                }


            }
            else
            {

                destRot = Quaternion.LookRotation(destVect);
                //chase behavour
                transform.rotation = Quaternion.RotateTowards(transform.rotation, destRot, rotSpeed * Time.deltaTime);
                transform.eulerAngles = new Vector3(0.0F, transform.eulerAngles.y, 0.0F); // Zeroing out all but Y rotation. 2.5D
                
            }
            //Move along Z...
            transform.Translate(Vector3.forward * ((isWandering ? wanderSpeed : moveSpeed) * Mathf.Clamp((distTo / slowDist), 0.0F, 1.0F) * Time.deltaTime));
            //anim.speed = 0.2f * (isWandering ? wanderSpeed : moveSpeed) * Mathf.Clamp((distTo / slowDist), 0.0F, 1.0F);


        }


        if (distTo <= seekDist)
        {
            SetWandering(false);
        }
		 else if ( distTo <= stopDist ) //distance checking 
		{
			SetMoving(false);
		}
		else
		{
			SetMoving(true);
            SetWandering(true);
		}
        
	}
    



	public void SetMoving(bool toggle)
	{
		isMoving = toggle; //for motion
		//anim.SetBool("isMoving", toggle); //for animation
	}

    public void SetWandering(bool toggle)
    {
        isWandering = toggle;
    }

    void GetNewDest()
    {
        destRot = this.transform.rotation;
        destRot *= Quaternion.Euler(0, Random.Range(-90, 90), 0);

    }

}
