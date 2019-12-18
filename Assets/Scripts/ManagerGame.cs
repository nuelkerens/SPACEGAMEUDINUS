using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerGame : MonoBehaviour {

	// Use this for initialization
	public GameObject panelPause;
	
	public void PauseControl(){
		if(Time.timeScale==1){
			panelPause.SetActive (true);
			Time.timeScale=0;
		}else{
			Time.timeScale=1;
			panelPause.SetActive(false);
		}
	}
	public void restart(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		Time.timeScale=1;
	}
	
	public void menu1(){
		Application.LoadLevel(1);
	}

}
