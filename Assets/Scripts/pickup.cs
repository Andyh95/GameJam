using UnityEngine;
using System.Collections;

public class pickup : MonoBehaviour {

	void OnTriggerEnter2D()
	{
		Destroy (this.gameObject);
	}
}
