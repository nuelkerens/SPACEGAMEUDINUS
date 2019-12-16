using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslasiObjek : MonoBehaviour {
public float movespeed;
Vector3 kekanan;
Vector3 kekiri;
Vector3 keatas;
Vector3 kebawah;

public GameObject Player;
	// Use this for initialization
	void Start () {
		kekanan = new Vector3(1,0,0);
		kekiri = new Vector3(-1,0,0);
		keatas = new Vector3(0,1,0);
		kebawah = new Vector3(0,-1,0);
	}
	
	// Update is called once per frame
	void Update () {
			if (Player.transform.position.x > transform.position.x)
	transform.position = transform.position + (kekanan * movespeed * Time.deltaTime );

		if (Player.transform.position.x < transform.position.x)
	transform.position = transform.position + (kekiri * movespeed * Time.deltaTime );

		if (Player.transform.position.y > transform.position.y)
	transform.position = transform.position + (keatas * movespeed * Time.deltaTime );

		if (Player.transform.position.y < transform.position.y)
	transform.position = transform.position + (kebawah * movespeed * Time.deltaTime );
	}
}
