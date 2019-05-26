using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDie : MonoBehaviour {

	// Use this for initialization
	private EnemyMovement EnemyObject;
	
	void Start ()
	{

		EnemyObject = gameObject.transform.GetComponentInParent<EnemyMovement>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}


	private void OnTriggerEnter2D(Collider2D other)
	{//Debug.Log(("Kill Enemy"));
		//if (other.IsTouchingLayers(LayerMask.GetMask("Player")))
		if(other.gameObject.name=="Player")
		{
            			
			EnemyObject.Die();
			
			Destroy((this.gameObject));
			Debug.Log(("Kill Enemy"));
			
		}


	}
}
