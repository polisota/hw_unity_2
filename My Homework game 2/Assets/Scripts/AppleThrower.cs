using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppleThrower : MonoBehaviour
{
    public float throwForce = 1f;
    public GameObject applePrefab;
   

    void Update()
    {            
        if (Input.GetKeyDown(KeyCode.E))
        {
            Throw();                  
            Debug.Log("E key was pressed.");
        }        
    }
    
    void Throw()
    {
       GameObject apple = Instantiate(applePrefab, transform.position, transform.rotation);
       Rigidbody rb = apple.GetComponent<Rigidbody>();
       rb.AddForce(transform.forward * throwForce, ForceMode.VelocityChange);
    }
    
}
