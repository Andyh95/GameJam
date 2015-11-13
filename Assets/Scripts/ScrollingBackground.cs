using UnityEngine;
using System.Collections;

public class ScrollingBackground : MonoBehaviour {


		
	void Update()
	{
		MeshRenderer mr = GetComponent<MeshRenderer> ();
			
		Material mat = mr.material;
			
		Vector2 offset = mat.mainTextureOffset;
			
		offset.x += Time.deltaTime / 10f;
			
		mat.mainTextureOffset = offset;
	}

}
