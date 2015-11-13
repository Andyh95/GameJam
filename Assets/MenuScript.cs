using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {
	public bool gameSoundOn = true;

	public void OnClickPlay()
	{
		// This add the button click function to change from current scene to "GameScene"
		//Application.LoadLevel ("Game"); // Uncomment previous code, change "Game to "name of the scene" and delete this comment after merging with Master branch to create connection to game scene.
		print ("Scene Change!");
	}

	public void VolumeToggle()
	{
		// Add volume control code after merging to master branch
		 gameSoundOn = !gameSoundOn;
	}

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {

	}
}
