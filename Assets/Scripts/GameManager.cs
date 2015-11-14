using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject terrain;
	public float terrainGenCooldown;
	public Transform[] spawnPoints;
	
	public float platformCooldown;
	// Use this for initialization
	void Start () {
		terrainGenCooldown = 0.5f;
		platformCooldown = 80.0f;
	}
	
	// Update is called once per frame
	void Update () {
		terrainGenCooldown--;
		platformCooldown--;
		
		if (terrainGenCooldown <= 0) {
			Instantiate (terrain, new Vector3 (11.5f, -4.5f, 0),transform.rotation);
			terrainGenCooldown = 24f;
		}
		if (platformCooldown <= 0) {
			int spawnPos = Random.Range(0,4);
			int spawnLength = Random.Range(2,6);
            GameObject platform;
            platform = Instantiate(terrain, spawnPoints[spawnPos].position, spawnPoints[spawnPos].rotation) as GameObject;
            platform.AddComponent<platformSpawn>();
            platform.GetComponent<platformSpawn>().SetSpawnAmmount(spawnLength);
            platform.GetComponent<platformSpawn>().SetObject(terrain);
            platformCooldown = 80.0f;
			

		}

	}
			
}


	
