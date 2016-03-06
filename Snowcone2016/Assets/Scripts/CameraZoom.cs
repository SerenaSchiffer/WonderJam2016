﻿using UnityEngine;
using System.Collections;

public class CameraZoom : MonoBehaviour {

    public float minFOV = 5f;
    public float maxFOV = 15f;
    public float zoomSpeed = 1f;

    public float cameraSize = 9f;
	// Use this for initialization
	void Start () {
        Camera.main.orthographicSize = cameraSize;
        
	}
	
	// Update is called once per frame
	void Update () {
        cameraSize += Input.GetAxis("Mouse ScrollWheel")*-1 * zoomSpeed;
        cameraSize = Mathf.Clamp(cameraSize, minFOV, maxFOV);
        Camera.main.orthographicSize = cameraSize;
    }

    public void centerCameraOnCharacter()
    {
        Camera.main.transform.position = new Vector3(GameObject.FindGameObjectWithTag("character").transform.position.x, GameObject.FindGameObjectWithTag("character").transform.position.z, -10);
    }
}
