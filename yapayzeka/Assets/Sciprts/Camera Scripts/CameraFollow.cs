using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    
    public Transform playerTransform;
    private void Update()
    {
       transform.position = playerTransform.position;
       transform.rotation = playerTransform.rotation;
       
    }
}
