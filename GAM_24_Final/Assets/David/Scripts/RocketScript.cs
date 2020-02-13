using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketScript : MonoBehaviour 
{
    [SerializeField]
    private float startingVelocity = 20f;
    [SerializeField]
    private float radius = 10f;
    private float force = 200f;
    private float up = 500;



    public float damage = 10f;
    public float delay  = 3f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, delay);
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = transform.forward * startingVelocity;
    }
    public void OnCollisionEnter(Collision collision)
    {

        Collider[] hits = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider hit in hits)
        {
            if (hit.gameObject == gameObject)
                continue;
            Rigidbody rigidbody = hit.gameObject.GetComponent<Rigidbody>();

            if(rigidbody !=null)
                rigidbody.AddExplosionForce(force, transform.position, radius, up);
        }
        Destroy(gameObject);
    }



}

