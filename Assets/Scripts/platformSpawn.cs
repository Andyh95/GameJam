using UnityEngine;
using System.Collections;

public class platformSpawn : MonoBehaviour {

    public GameObject terrain;
	GameObject pickup;
	bool isPickup = false;
    float spawnCooldown;
    float offSet = 2.37f;
    int spawnAmmount;


	public GameObject clover;
	// Use this for initialization
	void Start () {
        spawnCooldown = 24f;

	}
	
	// Update is called once per frame
	void Update () {
        spawnCooldown--;

	    while (spawnAmmount>0)
        { 
			GameObject platform;
            platform = Instantiate(terrain, new Vector3(transform.position.x+offSet,transform.position.y,transform.position.z), transform.rotation) as GameObject;
			platform.transform.localScale -= new Vector3(0,0.15f,0);
			spawnAmmount--;
            offSet += 2.37f;
        }

		if (isPickup) {
			Instantiate (pickup, new Vector3(transform.position.x + offSet - Random.Range(0, offSet-2.37f),transform.position.y+1.0f,transform.position.z),transform.rotation);
			isPickup =false;
		}
	



	}

    public void SetSpawnAmmount(int ammount)
    {
        spawnAmmount = ammount;
        Debug.Log("platform length :"+ ammount);
    }

    public void SetObject(GameObject obj)
    {
        terrain = obj;
    }

	public void SetPickup(GameObject newPickup)
	{
		pickup = newPickup;
		isPickup = true;
	}
}
