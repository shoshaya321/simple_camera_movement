using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    public float speedH = 3f;
    public float speedV = 3f;
    float newRotationX;
    float newRotationY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        newRotationY -= speedH * Input.GetAxis("Mouse X");
        newRotationX += speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3 (newRotationX, newRotationY, 0);
    }
}
