using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trailerrotate : MonoBehaviour
{
   
    public float speed = 5f; // Speed of movement

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}

