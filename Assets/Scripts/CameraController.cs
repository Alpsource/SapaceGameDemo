using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    public Vector2 borders;

    private void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60;
    }
    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        if (desiredPosition.x < borders.x) desiredPosition.x = borders.x;
        else if (desiredPosition.x > borders.y) desiredPosition.x = borders.y;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        //transform.LookAt(target);
    }
}
