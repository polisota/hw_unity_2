using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public float delay = 1f;
    public float radius = 5f;
    public float force = 100f;

    public GameObject appleEffect;

    float countdown;
    bool hasHit = false;
    
    void Start()
    {
        countdown = delay;
    }
   
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0f && !hasHit)
        {
            Hit();
            hasHit = true;
        }
    }

    void Hit()
    {
        Instantiate(appleEffect, transform.position, transform.rotation);

        Collider[] collidersToDestroy = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider nearbyObject in collidersToDestroy)
        {    
            Destructible dest = nearbyObject.GetComponent<Destructible>();
            if (dest != null)
            {
                dest.Destroy();
            }
        }

        Collider[] collidersToMove = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider nearbyObject in collidersToMove)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(force, transform.position, radius);
            }
        }


        Destroy(gameObject);

        Debug.Log("Hit");
    }
}
