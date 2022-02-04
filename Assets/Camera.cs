using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] GameObject followObject;
    Vector3 cameraOffset = new Vector3(0, 0, -20);
    void LateUpdate()
    {
        transform.position = followObject.transform.position + cameraOffset;
    }
}
