using UnityEngine;
using System.Collections;

public class Cat : MonoBehaviour {
	public Transform target = null;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float speed = target.position.x - transform.position.x;
		transform.position = new Vector3 (transform.position.x + (float)(speed * 0.5f), transform.position.y, transform.position.z);
	
	}

	public void increaseDistance(){
		target.position += new Vector3 (0.8f, 0.0f, 0.0f);
		Debug.Log ("increase");
	}
	public void decreaseDistance(){
		target.position -= new Vector3 (0.8f, 0.0f, 0.0f);
		Debug.Log ("decrease");
	}
}
