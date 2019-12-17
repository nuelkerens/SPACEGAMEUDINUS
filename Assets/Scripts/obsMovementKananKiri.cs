using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obsMovementKananKiri : MonoBehaviour
{
    public float moveSpeed=10f;
    bool moveRight = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x>10f){
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
        }
    }
}
