﻿using UnityEngine;

public class WebCam : MonoBehaviour {

	// Use this for initialization
	void Start () {

        WebCamDevice[] cameraDevices = WebCamTexture.devices;
        int viveCameraIndex;
        for (viveCameraIndex = 0; viveCameraIndex < cameraDevices.Length; viveCameraIndex++) {
            if (cameraDevices[viveCameraIndex].name.Equals("HTC Vive")) {
                break;
            }
        }

        Renderer rend = this.GetComponentInChildren<Renderer>();

        WebCamTexture myCamera = new WebCamTexture();
        string cameraName = cameraDevices[viveCameraIndex].name;
        myCamera.deviceName = cameraName;
        rend.material.mainTexture = myCamera;
        myCamera.Play();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}