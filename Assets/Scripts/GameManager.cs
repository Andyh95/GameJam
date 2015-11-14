using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject terrain;
	public float terrainGenCooldown;
	public Transform[] spawnPoints;
	public float backgroundGenCooldown1;
	public GameObject background1;
	public float backgroundGenCooldown2;
	public GameObject background2;
	public float backgroundGenCooldown3;
	public GameObject background3;
	public float platformCooldown;
	// Use this for initialization
	void Start () {
		terrainGenCooldown = 0.5f;
		backgroundGenCooldown1 = 0.0f;
		backgroundGenCooldown2 = 0.0f;
		backgroundGenCooldown3 = 0.0f;
		platformCooldown = 120.0f;
	}
	
	// Update is called once per frame
	void Update () {
		terrainGenCooldown--;
		platformCooldown--;
		backgroundGenCooldown1--;
		backgroundGenCooldown2--;
		backgroundGenCooldown3--;
		if (terrainGenCooldown <= 0) {
			Instantiate (terrain, new Vector3 (11.5f, -4.5f, 0),transform.rotation);
			terrainGenCooldown = 24f;
		}
		if (platformCooldown <= 0) {
			int spawnPos = Random.Range(0,4);
			int spawnLength = Random.Range(2,6);
            GameObject platform;
            platform = Instantiate(terrain, spawnPoints[spawnPos].position, spawnPoints[spawnPos].rotation) as GameObject;
			platform.transform.localScale -= new Vector3(0,0.15f,0);
            platform.AddComponent<platformSpawn>();
            platform.GetComponent<platformSpawn>().SetSpawnAmmount(spawnLength);
            platform.GetComponent<platformSpawn>().SetObject(terrain);
			platformCooldown = 120.0f;
		}
		if (backgroundGenCooldown1 <= 0) {
			Instantiate(background1, new Vector3(26.08f,0.57f,10),transform.rotation);
			backgroundGenCooldown1 = 489.0f;
		}if (backgroundGenCooldown2 <= 0) {
			Instantiate (background2, new Vector3 (26.06f, 0.57f, 9), transform.rotation);
			backgroundGenCooldown2 = 300.0f;
		}if (backgroundGenCooldown3 <= 0) {
			Instantiate(background3, new Vector3(26.03f,0.57f,8),transform.rotation);
			backgroundGenCooldown3 = 240.0f;
		}


	}
			
}


	
