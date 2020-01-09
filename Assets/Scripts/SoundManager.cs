using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	public static AudioClip jumpSound,dieSound,klikSound;
	
	static AudioSource audioSrc;
	// Use this for initialization
	void Start () {
		jumpSound = Resources.Load<AudioClip> ("shoot");
		dieSound = Resources.Load<AudioClip> ("enemy dead 07");
		klikSound = Resources.Load<AudioClip> ("Menu Selection Click");
	audioSrc = GetComponent<AudioSource> ();	 
	}
	
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void PlaySound (string clip ) {
		switch (clip)
		{
			case "jump":
			audioSrc.PlayOneShot (jumpSound);
			break;
			case "die":
			audioSrc.PlayOneShot (dieSound);
			break;
			case "klik":
			audioSrc.PlayOneShot (klikSound);
			break;		
		}
	}

}
