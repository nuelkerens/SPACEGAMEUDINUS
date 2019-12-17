using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleMovementSerong : MonoBehaviour {

    public float moveSpeed=10f;
    bool moveRight = true,moveUp=true;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y>109f){
            moveUp=false;
        }
        if(transform.position.y<89f){
            moveUp=true;
        }
        if(transform.position.x>13f ){
            moveRight = false;
        }
        if(transform.position.x<-13f){
            moveRight = true;
        }
        if(moveRight==true){
            transform.position = new Vector2(transform.position.x+moveSpeed*Time.deltaTime,transform.position.y);
        }
        if(moveUp==true){
             transform.position = new Vector2(transform.position.x,transform.position.y+moveSpeed*Time.deltaTime);
        }
        if(moveUp==false){
            transform.position = new Vector2(transform.position.x,transform.position.y-moveSpeed*Time.deltaTime);
        }
        if(moveRight==false){
            transform.position = new Vector2(transform.position.x-moveSpeed*Time.deltaTime,transform.position.y);
        }
       
    }
}
