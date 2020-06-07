using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public float radius = 5.0f;
    public float force = 200.0f;
    public void OnCollisionEnter(Collision collision)
    {
        print("event triggered");
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        foreach(Collider obj in colliders)
        {
            Rigidbody rd;
            if ((rd = obj.GetComponent<Rigidbody>()) != null) 
            {
                rd.AddExplosionForce(force, transform.position, radius);
            }
        }
    }
}
