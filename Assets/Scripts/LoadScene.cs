using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadingScene : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		
	}

	public void loadHardMode(){
		SceneManager.LoadScene("hardMode");
	}
}
