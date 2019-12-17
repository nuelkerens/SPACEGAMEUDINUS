using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class obstacleMovement : MonoBehaviour
{
    public float rotateSpeed;
    public float arah=1f;
    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate(0f,0f,arah * Time.deltaTime*rotateSpeed);
    }
}
