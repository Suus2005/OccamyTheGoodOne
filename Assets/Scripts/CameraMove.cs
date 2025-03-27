using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float rotationSpeed = 50f;  // Speed of rotation
    private bool isRotatingUp = false;  // To track if the "Rotate Up" button is being held
    private bool isRotatingDown = false;  // To track if the "Rotate Down" button is being held

    void Update()
    {
        // Rotate the camera while the corresponding button is held
        if (isRotatingUp)
        {
            transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
        }
        if (isRotatingDown)
        {
            transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime);
        }
    }

    // Method to start rotating up when the button is pressed
    public void StartRotateUp()
    {
        isRotatingUp = true;
    }

    // Method to stop rotating up when the button is released
    public void StopRotateUp()
    {
        isRotatingUp = false;
    }

    // Method to start rotating down when the button is pressed
    public void StartRotateDown()
    {
        isRotatingDown = true;
    }

    // Method to stop rotating down when the button is released
    public void StopRotateDown()
    {
        isRotatingDown = false;
    }
}
