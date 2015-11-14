using UnityEngine;
using System.Collections;

public class Terrain : MonoBehaviour {
	public float speed = 0.1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position -= new Vector3 (speed, 0, 0);
		if(transform.position.x < -15.0f){
			Destroy(this.gameObject);
		}
	}
}
