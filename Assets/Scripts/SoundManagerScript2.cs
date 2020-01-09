using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript2 : MonoBehaviour {
public static AudioClip jumpSound,dieSound,klikSound;
	// Use this for initialization
	static AudioSource audioSrc;
	// Use this for initialization
	void Start () {
		jumpSound = Resources.Load<AudioClip> ("jump_04");
		dieSound = Resources.Load<AudioClip> ("enemy_dead_07");
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
			audioSrc.PlayOneShot(jumpSound);
			break;
			case "mati":
			audioSrc.PlayOneShot (dieSound);
			break;
			case "klik":
			audioSrc.PlayOneShot (klikSound);
			break;		
		}
	}
}
