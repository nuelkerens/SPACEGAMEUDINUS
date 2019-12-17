using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obsMovementSerong : MonoBehaviour {

	float moveSpeed = 10f;
    bool moveSerong = true;
	public GameObject obs1,obs2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(obs1.transform.position.x < -10f && obs1.transform.position.y>59f){
			moveSerong = true;
		} if(obs1.transform.position.x>10f && obs1.transform.position.y<40f){
			moveSerong = false;
		}
		/*if(transform.position.x>10f){
            moveRight = false;
        }
        if(transform.position.x<-10f){
            moveRight = true;
        }
        if(moveRight==true){
            transform.position = new Vector2(transform.position.x+moveSpeed*Time.deltaTime,transform.position.y);
        }
        else{
            transform.position = new Vector2(transform.position.x-moveSpeed*Time.deltaTime,transform.position.y);
        }*/
		if(moveSerong == true){
			obs1.transform.position = new Vector2(obs1.transform.position.x+moveSpeed*Time.deltaTime,obs1.transform.position.y-moveSpeed*Time.deltaTime);
		} else{
			obs1.transform.position = new Vector2(obs1.transform.position.x-moveSpeed*Time.deltaTime,obs1.transform.position.y+moveSpeed*Time.deltaTime);
		}
	}
}
