using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelLoader : MonoBehaviour {

	public GameObject loadingScreen;
	public Slider slider;

	public Text progressText;

	// Use this for initialization
	public void LoadLevel(int sceneIndex)
	{
		StartCoroutine(LoadAsynchronously(sceneIndex));
	}

//start scene loding disini 
	IEnumerator LoadAsynchronously (int sceneIndex)
	{
		//yield return new WaitForSeconds(3);
		AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
		
		loadingScreen.SetActive(true);

		while (!operation.isDone)
		{
			float progress = Mathf.Clamp01(operation.progress / .005f);
			
			slider.value = progress;
			progressText.text = progress * 100f  + "%";  

			yield return null;
		}
	}
	 
}
