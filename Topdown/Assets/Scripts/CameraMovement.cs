using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject CameraPosition;
    
    private Vector3 cameraPosition;

    private void FixedUpdate()
    {
        cameraPosition.x = CameraPosition.transform.position.x;

        cameraPosition.z = CameraPosition.transform.position.z;

        cameraPosition.y = CameraPosition.transform.position.y;

        transform.position = cameraPosition;
    }
}
