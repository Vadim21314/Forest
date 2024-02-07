using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CameraController : MonoBehaviour
{
    public float sensivity = 2.0f;
    public float maxYAngle = 80.0f;
 
    float rotationX = 0.0f;
    float rotationY = 0.0f;

    private void Update()

    
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        transform.parent.Rotate(Vector3.up * mouseX * sensivity);

        rotationX -= mouseY * sensivity;
        rotationY = Mathf.Clamp(rotationX, -maxYAngle, maxYAngle);
        transform.localRotation = Quaternion.Euler(rotationX, 0.0f, 0.0f);
    }
}