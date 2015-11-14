using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {
	// Time interval between the footstep sound looping
	public float stepCooldown = 20.0f;
	// Determine if game sound is on and how loud it is(0-100% in form of 0-1)
	public bool gameSoundOn = true;
	public Slider volumeSlider;
	public float gameSoundVolume = 1; // The starting volume of the game
	// This allow insert of the footstep audio and source it
	public AudioClip footstep;
	AudioSource footstepSource;
	// The starting pitch of the footsteps, this help create more realistic footsteps
	public float footstepPitch = 1.0f;


	public void OnClickPlay()
	{
		// This add the button click function to change from current scene to "GameScene"
		//Application.LoadLevel ("Game"); // Uncomment previous code, change "Game to "name of the scene" and delete this comment after merging with Master branch to create connection to game scene.
		print ("Scene Change!");
	}

	public void VolumeToggle()
	{
		// This turn the sound on/off on function call
		gameSoundOn = !gameSoundOn;
	}

	// Use this for initialization
	void Start () {
		footstepSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		// This get the volume slider current value
		gameSoundVolume = volumeSlider.value;

		// This limit the lower and upper bound of the pitch of the footstep audio
		if (footstepPitch > 1.5f) {
			footstepPitch = 1.3f;
		} else if (footstepPitch < 0.65f) 
		{
			footstepPitch = 0.75f;
		}

		// This function is called when stepCooldown is down to 0, allowing interval between sound play
		if (stepCooldown <= 0.0f) {
			// This randomise the pitch bounded by number related to the last audio play back
			footstepSource.pitch = Random.Range (footstepPitch - 0.25f, footstepPitch + 0.25f);
			// footstep sound are only played if gameSoundOn is true
			if (gameSoundOn)
			{
				// This play back the footstep audio once with a randomised volume that are multiplied by the gameSoundVolume setting
				footstepSource.PlayOneShot (footstep, (Random.Range (0.5f, 1.0f) * gameSoundVolume));
			}
			// This set the current pitch as medium for the next play back
			footstepPitch = footstepSource.pitch;
			// This reset the stepCooldown to a randomised value for a more realistic footstep
			stepCooldown = Random.Range (16.0f, 24.0f);
		} else {
			// decreasing the stepCooldown per update when stepCooldown has not reached 0
			stepCooldown--;
		}
	}
}
