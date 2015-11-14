using UnityEngine;
using System.Collections;

public class ScrollingBackground : MonoBehaviour {
	public GameObject background;
	public float speed;
	//public float backgroundCooldown = 30.0f;
		
	void Update()
	{
		//backgroundCooldown--;
		//if (backgroundCooldown <= 0) {
		//	Instantiate (background, new Vector3 (26.12f, 0.57f, 10f), transform.rotation);
		//	backgroundCooldown = 30.0f;
		//}
			if(transform.position.x < -50.0f){
				Destroy(this.gameObject);
			}
			transform.position -= new Vector3(speed,0.0f,0.0f);
		}
	}


