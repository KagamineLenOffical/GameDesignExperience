using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSphere : MonoBehaviour
{
    public GameObject Sphere;
    public float force = 2.0f;
    public void Shoot()
    {
      
        GameObject clone = Instantiate(Sphere,new Vector3(3,0.25f,3), Sphere.transform.rotation) as GameObject;
        Rigidbody rb = clone.GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(0,0,-1) * force);
    }
}
