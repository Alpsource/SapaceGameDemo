using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    private Rigidbody myRigid;
    [Range(0, 1)]
    public float rotationSpeed;
    void Start()
    {
        myRigid = transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        myRigid.AddForce(1 * transform.up, ForceMode.Force);
    }
    private void Update()
    {
        RotatewrtInput();
    }

    private void RotatewrtInput()
    {

        float targetAngle = InputManager.Instance.getHorizontalInput()*20;
        Vector3 selfAngle = transform.eulerAngles;

        float newAngle = Mathf.LerpAngle(selfAngle.z, targetAngle, rotationSpeed);
        selfAngle.z = newAngle;

        // Calculate a rotation a step closer to the target and applies rotation to this object
        transform.eulerAngles = selfAngle;
    }
}
