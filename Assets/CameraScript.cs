﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float speedh;
    public float speedv;
    public float sens;
    public float Yaw;
    public float Pitch;
    public float Zew;
    private float StartYaw;
    private float StartPitch;
    private float StartZew;
    private Vector3 myCamPos;
    void Start()
    {
        //Rotina que salva os valores iniciais dos parâmetros da câmera.  
        myCamPos = transform.position;
        StartYaw = Yaw;
        StartPitch = Pitch;
        StartZew = Zew;
        ResetCam();
    }

    void ResetCam()
    {
        //Rotina que coloca a câmera na posição inicial.  
        transform.position = myCamPos;
        Yaw = StartYaw;
        Pitch = StartPitch;
        Zew = StartZew;
        transform.eulerAngles = new Vector3(Pitch, Yaw, Zew);
    }
    void Update()
    {
        //Rotina que atualiza a posição da câmera conforme o input do usuário.
        if (Input.GetKey(KeyCode.R))
        {
            ResetCam();
        }
        if (Input.GetKey(KeyCode.W) | Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * sens);
        }
        if (Input.GetKey(KeyCode.A) | Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * sens);
        }
        if (Input.GetKey(KeyCode.S) | Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * sens);
        }
        if (Input.GetKey(KeyCode.D) | Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * sens);
        }

        if (Input.GetMouseButton(1))
        {
            Yaw += speedh * Input.GetAxis("Mouse X");
            Pitch -= speedv * Input.GetAxis("Mouse Y");
            transform.eulerAngles = new Vector3(Pitch, Yaw, Zew);
        }
    }
}
