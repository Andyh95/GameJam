using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public WebCamTexture mCamera = null;
    public GameObject plane;

    // Use this for initialization
    void Start()
    {
        Debug.Log("Script has been started");
        plane = GameObject.FindWithTag("Player");

  //      WebCamDevice[] devices = WebCamTexture.devices;
  //      for (var i = 0; i < devices.Length; i++)
  //          Debug.Log(devices[i].name);
  //      }

  //  WebCamDevice[] devices = WebCamTexture.devices;
  
  //foreach(WebcamDevice cam in devices)
  //{
  //   if(cam.isFrontFacing )
  //   {    
  //       webCameraTexture  =    new WebCamTexture(cameraIndex, Screen.width, Screen.height);
  //  webCameraTexture.deviceName  = cam.name;
  //       webCameraTexture.Play();
  //   }
  //}

    mCamera = new WebCamTexture("Camera 1");
        plane.GetComponent<Renderer>().material.mainTexture = mCamera;
        mCamera.Play();

    }

    // Update is called once per frame
    void Update()
    {

    }
}