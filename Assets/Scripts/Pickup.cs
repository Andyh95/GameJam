using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {
	
	void OnTriggerEnter2D()
	{
		Destroy (this.gameObject);
	}

}
