using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotstion : MonoBehaviour
{
    public float rotationSpeed = 100f; // The speed at which the object rotates

    private bool rotateLeft = false;
    private bool rotateRight = false;

    // Start rotating left when the button is pressed
    public void OnPointerDownLeft()
    {
        rotateLeft = true;
    }

    // Stop rotating when the button is released
    public void OnPointerUpLeft()
    {
        rotateLeft = false;
    }

    // Start rotating right when the button is pressed
    public void OnPointerDownRight()
    {
        rotateRight = true;
    }

    // Stop rotating when the button is released
    public void OnPointerUpRight()
    {
        rotateRight = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the object based on the input flags
        if (rotateLeft)
        {
            transform.Rotate(Vector3.up * -rotationSpeed * Time.deltaTime);
        }

        if (rotateRight)
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }
}
