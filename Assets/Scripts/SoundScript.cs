using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SoundScript : MonoBehaviour {
	
	// Game volume control
	// Determine if game sound is on and how loud it is(0-100% in form of 0-1)
	public bool gameSoundOn = true;
	public Slider volumeSlider;
	public float gameSoundVolume = 1; // The starting volume of the game as 100%

	// Footstep initialisation
	// This allow insert of the footstep audio and source it
	public AudioClip footstep;
	AudioSource footstepSource;
	// Time interval between the footstep sound looping
	public float stepCooldown = 20.0f;
	// The starting pitch of the footsteps, this help create more realistic footsteps
	public float footstepPitch = 1.0f;
	public bool isJumping = false;

	// Meow initialisation
	// This allow insert of the meow audios and source them
	public AudioClip meow00;
	public AudioClip meow01;
	public AudioClip meow02;
	public AudioClip meow03;
	public AudioClip meow04;
	public AudioClip meow05;
	AudioSource meowSource;
	// Time Interval between the meow sound
	public float meowCooldown = 100.0f;
	
	// This turn the sound on/off on function call
	public void SoundToggle()
	{
		gameSoundOn = !gameSoundOn;
	}

	// Use this for initialization
	void Start () {
		footstepSource = GetComponent<AudioSource>();
		meowSource = GetComponent <AudioSource>();
	
	}
	
	// Update is called once per frame
	void Update () {
		// This get the volume slider current value
		gameSoundVolume = volumeSlider.value;

		if (Application.loadedLevelName == "Game") {
			if (!isJumping)
			{
				FootStep();
			}
			Meow ();
			
		}
	}

	// This function prevent the sound managing object from being deleted when scenes are loaded
	void Awake()
	{
		DontDestroyOnLoad (transform.gameObject);
	}

	// This function plays the footstep sound
	void FootStep()
	{
		// This limit the lower and upper bound of the pitch of the footstep audio
		if (footstepPitch > 1.5f) {
			footstepPitch = 1.3f;
		} else if (footstepPitch < 0.65f) 
		{
			footstepPitch = 0.75f;
		}

		// This is called when stepCooldown is down to 0, allowing interval between sound play
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

	void Meow()
	{
		// This is called when stepCooldown is down to 0, allowing interval between sound play
		if (meowCooldown <= 0.0f) {
			int meowPicker = Random.Range (0, 6);

			if (gameSoundOn)
			{
				switch (meowPicker) {
				case 0:
					meowSource.clip = meow00;
					meowSource.PlayOneShot (meow00, (Random.Range (0.5f, 1.0f) * gameSoundVolume));
					break;
				case 1:
					meowSource.clip = meow01;
					meowSource.PlayOneShot (meow01, (Random.Range (0.3f, 0.5f) * gameSoundVolume));
					break;
				case 2:
					meowSource.clip = meow02;
					meowSource.PlayOneShot (meow02, (Random.Range (0.4f, 0.75f) * gameSoundVolume));
					break;
				case 3:
					meowSource.clip = meow03;
					meowSource.PlayOneShot (meow03, (Random.Range (0.5f, 1.0f) * gameSoundVolume));
					break;
				case 4:
					meowSource.clip = meow04;
					meowSource.PlayOneShot (meow04, (Random.Range (0.5f, 1.0f) * gameSoundVolume));
					break;
				case 5:
					meowSource.clip = meow05;
					meowSource.PlayOneShot (meow05, (Random.Range (0.5f, 1.0f) * gameSoundVolume));
					break;
				}
			}

			meowCooldown = Random.Range (300.0f, 380.0f);
			
		} else {
			// decreasing the stepCooldown per update when stepCooldown has not reached 0
			meowCooldown--;
		}
	}

	public void IsJumpingSetter(bool setter)
	{
		isJumping = setter;
	}
}
