using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peluru : MonoBehaviour {

  public float Speed;
    // Start is called before the first frame update
    void Start()
    {
			GetComponent<Rigidbody2D>().velocity = Vector2.left * Speed;
		
    }

}
