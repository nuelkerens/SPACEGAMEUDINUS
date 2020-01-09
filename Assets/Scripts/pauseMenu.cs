using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour {
	public static bool gamePaused = false;
	public GameObject pauseMenuUI;
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			if(gamePaused){
				resume();
			}else{
				pause();
			}
		}
	}

	public void resume(){
		pauseMenuUI.SetActive(false);
		Time.timeScale = 1f;
		gamePaused=false;
	}
	void pause(){
		pauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
		gamePaused=true;
	}

	public void LoadMenu(){
		SceneManager.LoadScene("MainMenu");
		Time.timeScale=1f;
	}

	public void QuitGame(){
		Application.Quit();
	}
}
