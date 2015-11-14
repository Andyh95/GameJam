using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public Animator anim;
    public GameObject particles;
    bool falling = false;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		SoundScript sound = FindObjectOfType<SoundScript> ();

		if (Input.GetKeyUp (KeyCode.Space)) {
			anim.SetTrigger("Jump");
			//transform.position += new Vector3(0,2.0f,0);
			GetComponent<Rigidbody2D>().velocity = new Vector2 (0.0f,5.0f);
			sound.IsJumpingSetter(true);
			Debug.Log("Jump");
			}
		if (GetComponent<Rigidbody2D> ().velocity.y > 0) {
			anim.SetBool ("Jumping", true);
			anim.SetBool ("Falling", false);
			sound.IsJumpingSetter(true);
		} else if (GetComponent<Rigidbody2D> ().velocity.y < 0) {
			anim.SetBool ("Jumping", false);
			anim.SetBool ("Falling", true);
            falling = true;
			sound.IsJumpingSetter(true);
		} else {
			anim.SetBool ("Jumping", false);
			anim.SetBool ("Falling", false);
			sound.IsJumpingSetter(false);
            if (falling)
            {
                particles.GetComponent<Particles>().Emit(5);
                falling = false;
            }
		}
		
	}

}