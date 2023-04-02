using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingStarBehavior : MonoBehaviour
{
    public Vector2 Direction;
    private Rigidbody myRigid;

    void Start()
    {
        myRigid = transform.GetComponent<Rigidbody>();
        myRigid.AddForce(0.5f * Direction, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
