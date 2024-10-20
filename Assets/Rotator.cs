using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Rotator : MonoBehaviour
{
   public float speed;

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().Rotate(0f, speed, 0f);
        
    }
}
