using UnityEngine;
using System.Collections;

public class Mirror : MonoBehaviour {

    public WebCamTexture mCamera = null;

    // Use this for initialization
    void Start () {

        mCamera = new WebCamTexture("Camera 1");
        GetComponent<Renderer>().material.mainTexture = mCamera;
        mCamera.Play();

        transform.Rotate(new Vector3(0.0f, 180.0f, 0.0f));

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
