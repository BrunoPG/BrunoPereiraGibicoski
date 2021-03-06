﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float speedh;
    public float speedv;
    public float sens;
    private float yaw = 0.0f;
    private float pitch = 0.0f;
    private float Zew = 0.0f;
    private GameObject MyCamera;
    // Start is called before the first frame update
    void Start()
    {
      MyCamera = GameObject.Find("Main Camera");  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){
            MyCamera.transform.Translate(Vector3.forward * sens);
        //transform.position = ;
        }
        if (Input.GetKey(KeyCode.A)){
           MyCamera.transform.Translate(Vector3.left * sens);
        }
        if (Input.GetKey(KeyCode.S)){
           MyCamera.transform.Translate(Vector3.back * sens);
        }
        if (Input.GetKey(KeyCode.D)){
           MyCamera.transform.Translate(Vector3.right * sens);
        }

        if (Input.GetMouseButton(1)){
        yaw += speedh * Input.GetAxis("Mouse X");
        pitch -= speedv * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, Zew);
        }
    }
}
