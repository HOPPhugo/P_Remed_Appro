
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class CameraFollow : MonoBehaviour
{
    public Transform followTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(followTransform.position.x, followTransform.position.y, this.transform.position.z);
    }
}
