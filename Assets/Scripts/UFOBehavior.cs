using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOBehavior : MonoBehaviour
{
    public float Range;
    private Rigidbody myRigid;
    private Transform target;
    private bool armed = false;

    void Start()
    {
        myRigid = transform.GetComponent<Rigidbody>();
        myRigid.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!armed)
        {
            Collider[] hitColliders = Physics.OverlapSphere(transform.position, Range);
            foreach (var hitCollider in hitColliders)
            {
                if (hitCollider.transform.tag == "Player")
                {
                    target = hitCollider.transform;
                    armed = true;
                    myRigid.isKinematic = false;
                }
            }
        }
        else
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, 
                Quaternion.LookRotation(target.position - transform.position), Time.time * 0.5f);
        }
    }
    private void FixedUpdate()
    {
        if (armed)
        {
            myRigid.AddForce(2.5f*(target.position - transform.position), ForceMode.Force);
        }
    }
}
