using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pesawat : MonoBehaviour {

	public float Speed;
    public float ShootTime;
    float currentShootTime;
	 public GameObject Projectile;
	// Use this for initialization
	void Start () {
        currentShootTime = ShootTime;
	}
	private void OnTriggerStay2D(Collider2D other) {
		if (other.gameObject.name.Equals ("player")){
			if(transform.position.x<-11f){
			 GetComponent<Rigidbody2D>().velocity = Vector2.right * Speed;
			}
			if(transform.position.x>11f){
			 GetComponent<Rigidbody2D>().velocity = Vector2.left * Speed;
			}
		}
		
	}
	// Update is called once per frame
	void Update () {
		 if(currentShootTime > 0) {
            currentShootTime -= Time.deltaTime;
        } else {
            Shoot();
            currentShootTime = ShootTime;    
        }
	}

	void Shoot(){
        Vector3 projectilePosition = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
        Instantiate(Projectile, projectilePosition, Quaternion.Euler(0,0, 0));
    }

}
