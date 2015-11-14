using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {
	public float stepCooldown = 20.0f;

	public bool gameSoundOn = true;
	public AudioClip footstep;
	public float footstepPitch = 1.0f;

	AudioSource footstepSource;

	
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
		footstepSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (footstepPitch > 1.5f) {
			footstepPitch = 1.3f;
		} else if (footstepPitch < 0.65f) 
		{
			footstepPitch = 0.75f;
		}

		if (stepCooldown <= 0.0f) {
			footstepSource.pitch = Random.Range (footstepPitch - 0.25f, footstepPitch + 0.25f);
			footstepSource.PlayOneShot (footstep, Random.Range (0.3f, 1.0f));
			footstepPitch = footstepSource.pitch;
			stepCooldown = Random.Range (16.0f, 24.0f);
		} else {
			stepCooldown--;
		}
	}
}
