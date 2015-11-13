using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject terrain;
	public float terrainGenCooldown;
	// Use this for initialization
	void Start () {
		terrainGenCooldown = 0.05f;
	}
	
	// Update is called once per frame
	void Update () {
		terrainGenCooldown--;
		if (terrainGenCooldown <= 0) {
			Instantiate (terrain, new Vector3 (11.5f, -4.5f, 0),transform.rotation);
			terrainGenCooldown = 23.5f;
		} 

	}
}
