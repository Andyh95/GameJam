﻿using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void OnClickPlay()
	{
		Application.LoadLevel ("Game");
		print ("level changed");
	}

	public void OnClickReturnMenu()
	{
		Application.LoadLevel ("GameMenu");
		print ("level changed to game menu");
	}
}
