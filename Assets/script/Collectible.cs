using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Collectible : MonoBehaviour
{
    public int points = 1;

    public float rotationSpeed = 100f;

    
 
    void Update()
    {
        RotateObject();
    }

    void RotateObject()
    {
        transform.Rotate(0f, rotationSpeed,0f  * Time.deltaTime);
    }
    
}
