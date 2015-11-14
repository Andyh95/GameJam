using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {

	public void OnClickPlay()
	{
		// This add the button click function to change from current scene to "GameScene"
		Application.LoadLevel ("Game");
		print ("Scene Change!");
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
