using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{   
    public GameObject obj;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var inv = other.GetComponent<Inventory>();
            if (inv.GetItem(2))
            {
                obj.SetActive(true);
            }            
        }
    }
    
}
