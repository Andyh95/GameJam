using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public Animator anim;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Space)) {
			anim.SetTrigger("Jump");
			//transform.position += new Vector3(0,2.0f,0);
			GetComponent<Rigidbody2D>().velocity = new Vector2 (0.0f,5.0f);
			Debug.Log("Jump");
			}
		if (GetComponent<Rigidbody2D> ().velocity.y > 0) {
			anim.SetBool ("Jumping", true);
			anim.SetBool ("Falling", false);
		} else if (GetComponent<Rigidbody2D> ().velocity.y < 0) {
			anim.SetBool ("Jumping", false);
			anim.SetBool ("Falling", true);
		} else {
			anim.SetBool ("Jumping", false);
			anim.SetBool ("Falling", false);
		}
		
	}

}