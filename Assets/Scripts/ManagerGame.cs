using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

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
		SoundManagerScript2.PlaySound ("klik");
		Time.timeScale=1;
	}
	
	public void menu1(){
		Application.LoadLevel(1);
		SoundManagerScript2.PlaySound ("klik");
	}

	public void OnSetting(){
	SceneManager.LoadScene("Credits");
		SoundManagerScript2.PlaySound ("klik");
	}
	public void OnHelp(){
	SceneManager.LoadScene("Help");
		SoundManagerScript2.PlaySound ("klik");
	}
public void OnBack(){
	SceneManager.LoadScene("MainMenu");
	SoundManagerScript2.PlaySound ("klik");
		
	}

public void OnCasual(){
	SceneManager.LoadScene("casualMode");
		SoundManagerScript2.PlaySound ("klik");
	}
public void OnHard(){
	SceneManager.LoadScene("hardMode");
		SoundManagerScript2.PlaySound ("klik");
	}
	public void OnPlay(){
	SceneManager.LoadScene("LevelMenu");
		SoundManagerScript2.PlaySound ("klik");
	}

}
