using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour {

	private Rigidbody2D rb;
	private float jumpforce = 40f;
    public GameObject checkpoint1,checkpoint2,checkpoint3;
    public Transform spawn,spawn1,spawn2,spawn3;
	public GameObject pesawat1,pesawat2,pesawat3,pesawat4;
    private bool cp1 = false,cp2=false,cp3=false;
	void Start () {
		Time.timeScale=1;
		rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Space)) {
			rb.AddForce(new Vector2(0f,jumpforce));		
		}
        if (transform.position.y > checkpoint1.transform.position.y + 2)
        {
            checkpoint1.GetComponent<BoxCollider2D>().enabled = true;
        }
		if (transform.position.y > checkpoint2.transform.position.y +2){
			checkpoint2.GetComponent<BoxCollider2D>().enabled = true;
		}
		if (transform.position.y > checkpoint3.transform.position.y +2){
			checkpoint3.GetComponent<BoxCollider2D>().enabled = true;
		}

	}
	 void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag=="comet")
        {
            Die();
        }
        if(coll.gameObject.tag == "checkpoint1")
        {
            cp1 = true;
        }
		if(coll.gameObject.tag =="checkpoint2"){
			cp1=false;
			cp2=true;
		}
		if(coll.gameObject.tag =="checkpoint3"){
			cp1=false;
			cp2=false;
			cp3=true;
		}
    }
	
	void Die(){
        if (cp1 == true)
        {
            transform.position = spawn1.position;
        }
		if(cp2 ==true){
			transform.position = spawn2.position;
		}
		if(cp3==true){
			transform.position = spawn3.position;
			pesawat1.transform.position=new Vector2(25,pesawat1.transform.position.y);
			pesawat2.transform.position=new Vector2(25,pesawat2.transform.position.y);
			pesawat3.transform.position=new Vector2(25,pesawat3.transform.position.y);
			pesawat4.transform.position=new Vector2(25,pesawat4.transform.position.y);
		}
        if(transform.position.y<checkpoint1.transform.position.y){
			transform.position = spawn.position;
		}
	}

}
