using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float cameraSpeed;


    void Update()
    {
        transform.position += new Vector3(0, cameraSpeed * Time.deltaTime, 0);
    }
}
