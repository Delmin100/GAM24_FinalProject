using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunOne : MonoBehaviour
{

    public GameObject rocketPrefab;

    public void Fire()
    {
        GameObject projectile = Instantiate(rocketPrefab, transform.position, transform.rotation);

        Rigidbody projectileRigidbody = projectile.GetComponent<Rigidbody>();
        Vector3 force = transform.TransformDirection(Vector3.forward) * 1000f;
        projectileRigidbody.AddForce(force);
    }

}
