using UnityEngine;
using System.Collections;

public class platformSpawn : MonoBehaviour {

    public GameObject terrain;
    float spawnCooldown;
    float offSet = 2.37f;
    int spawnAmmount;

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
}
