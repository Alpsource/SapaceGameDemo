using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    private Rigidbody myRigid;
    private bool armed;
    [Range(0, 1)]
    public float rotationSpeed;
    void Start()
    {
        myRigid = transform.GetComponent<Rigidbody>();
        armed = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(armed) myRigid.AddForce(20 * transform.up, ForceMode.Force);
    }
    private void Update()
    {
        if(armed)RotatewrtInput();
    }

    private void RotatewrtInput()
    {

        float targetAngle = InputManager.Instance.getHorizontalInput()*20;
        Vector3 selfAngle = transform.eulerAngles;

        float newAngle = Mathf.LerpAngle(selfAngle.z, targetAngle, rotationSpeed);
        selfAngle.z = newAngle;
        selfAngle.x = 0;
        selfAngle.y = 0;

        // Calculate a rotation a step closer to the target and applies rotation to this object
        transform.eulerAngles = selfAngle;
    }
    public void Activate()
    {
        armed = true;
    }
    public void Deactivate()
    {
        armed = false;
    }
}
