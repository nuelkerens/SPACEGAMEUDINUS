﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimerScript : MonoBehaviour {
	Image timebar;
	public float maxTime = 5f;
	public GameObject text,text2;
	float timeLeft;
	// Use this for initialization
	void Start () {
		timebar = GetComponent<Image>();
		timeLeft = maxTime;
	}
	
	// Update is called once per frame
	void Update () {
		if(timeLeft>0){
			timeLeft -= Time.deltaTime;
			timebar.fillAmount = timeLeft/maxTime;
		}else{
			text.SetActive(true);
			text2.SetActive(true);
			Time.timeScale=0;
		}
	}
}
