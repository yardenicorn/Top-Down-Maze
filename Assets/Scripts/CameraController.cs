using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject PlayerObject;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - PlayerObject.transform.position;
    }

    void LateUpdate()
    {
        transform.position = PlayerObject.transform.position + offset;
    }
}
