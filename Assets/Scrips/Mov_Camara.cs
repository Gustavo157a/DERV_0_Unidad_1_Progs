using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Camara : MonoBehaviour
{
    public float speedH;
    public float speedV;

    float yaw;
    float pithc;

    // Update is called once per frame
    void Update()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pithc -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pithc, yaw, 0.0f);

    }
}