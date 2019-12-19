using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucket : MonoBehaviour {

	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.name.Equals ("Cat"))
			rb.isKinematic = false;
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.name.Equals ("Cat"))
			Debug.Log ("Got you!");
	}

}
