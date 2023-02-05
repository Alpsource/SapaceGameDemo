using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetBehavior : MonoBehaviour
{
    private Vector3 direction;
    void Start()
    {
        direction = new Vector3(0.0f, 0.2f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(direction);
    }
    private void FixedUpdate()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, 10);
        Rigidbody col_rigid;
        foreach (var hitCollider in hitColliders)
        {
            if(hitCollider.TryGetComponent<Rigidbody>(out col_rigid))
            {
                col_rigid.AddForce(-1*(hitCollider.transform.position - transform.position)*(1/Vector3.Distance(hitCollider.transform.position, transform.position)),
                    ForceMode.Force);
            }
        }
    }
}
