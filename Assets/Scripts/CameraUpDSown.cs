using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraUpDSown : MonoBehaviour
{
    public float moveSpeed = 5f;  // Speed of camera movement
    private bool isMovingUp = false;  // Track if the "Move Up" button is held
    private bool isMovingDown = false;  // Track if the "Move Down" button is held

    void Update()
    {
        // Move the camera while the corresponding button is held
        if (isMovingUp)
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }
        if (isMovingDown)
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }
    }

    // Method to start moving up when the button is pressed
    public void StartMoveUp()
    {
        isMovingUp = true;
    }

    // Method to stop moving up when the button is released
    public void StopMoveUp()
    {
        isMovingUp = false;
    }

    // Method to start moving down when the button is pressed
    public void StartMoveDown()
    {
        isMovingDown = true;
    }

    // Method to stop moving down when the button is released
    public void StopMoveDown()
    {
        isMovingDown = false;
    }
}
