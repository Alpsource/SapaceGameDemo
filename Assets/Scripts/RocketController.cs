using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    private Rigidbody myRigid;
    void Start()
    {
        myRigid = transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        myRigid.AddForce(1 * transform.up, ForceMode.Force);
    }
}
