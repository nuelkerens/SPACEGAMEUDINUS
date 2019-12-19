using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCat : MonoBehaviour {

	float dirX;
	[SerializeField]
	float moveSpeed = 5f;

	// Update is called once per frame
	void Update () {
		dirX = Input.GetAxis ("Horizontal") * moveSpeed * Time.deltaTime;
		transform.position = new Vector2 (transform.position.x + dirX, transform.position.y);
	}
}
