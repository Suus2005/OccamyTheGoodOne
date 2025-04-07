using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hidden : MonoBehaviour
{
    public GameObject Idle, Kronkel, Fly, Stop, print;
    
    // Start is called before the first frame update
    void Start()
    {
        Idle.SetActive(false);
        Kronkel.SetActive(false);
        Fly.SetActive(false);
        print.SetActive(false);


    }


}
