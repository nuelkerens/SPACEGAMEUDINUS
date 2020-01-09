using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tabrak : MonoBehaviour {


	//Rigidbody2D  rb;

	//float dirX;
	//[SerializeField]
	public float moveSpeed ;

	// Use this for initialization
	void Start () {
		//rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D col)   // jika masuk death zone 
	{
		if (col.gameObject.name.Equals ("player"))
			 // rb.isKinematic = false;
			// dirX = Input.GetAxis ("Horizontal") * moveSpeed * Time.deltaTime;
	//	transform.position = new Vector2 (transform.position.x + dirX, transform.position.y);
	transform.position = new Vector3(transform.position.x-moveSpeed*Time.deltaTime,transform.position.y);
	  //transform.position = new Vector2(transform.position.x+moveSpeed*Time.deltaTime,transform.position.y);
	}

	void OnTriggerStay2D (Collider2D col) // jika ada di dalam death zone 
	{
		if (col.gameObject.name.Equals ("player"))
			 // rb.isKinematic = false;
			// dirX = Input.GetAxis ("Horizontal") * moveSpeed * Time.deltaTime;
	//	transform.position = new Vector2 (transform.position.x + dirX, transform.position.y);
	transform.position = new Vector3(transform.position.x-moveSpeed*Time.deltaTime,transform.position.y);
	  //transform.position = new Vector2(transform.position.x+moveSpeed*Time.deltaTime,transform.position.y);
	}
	void OnTriggerExit2D (Collider2D col) // jika keluar death zone 
	{
		if (col.gameObject.name.Equals ("player"))
			 // rb.isKinematic = false;
			// dirX = Input.GetAxis ("Horizontal") * moveSpeed * Time.deltaTime;
	//	transform.position = new Vector2 (transform.position.x + dirX, transform.position.y);
	transform.position = new Vector3(transform.position.x-moveSpeed*Time.deltaTime,transform.position.y);
	  //transform.position = new Vector2(transform.position.x+moveSpeed*Time.deltaTime,transform.position.y);
	}

	//void OnCollisionEnter2D (Collision2D col)
	//{
	//	if (col.gameObject.name.Equals ("player"))
	//		Debug.Log ("Got you!");
	//}
}
