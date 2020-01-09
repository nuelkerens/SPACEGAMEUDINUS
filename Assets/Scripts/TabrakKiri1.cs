using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabrakKiri1 : MonoBehaviour {


	public float moveSpeed ;
	
	void OnTriggerEnter2D (Collider2D col)   // jika masuk death zone 
	{
		if (col.gameObject.name.Equals ("player")){
			GetComponent<Rigidbody2D>().velocity = Vector2.right * moveSpeed;
		}
	
	}
}
