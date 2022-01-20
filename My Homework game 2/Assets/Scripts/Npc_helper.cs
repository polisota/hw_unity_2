using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc_helper : MonoBehaviour
{    
    public GameObject obj;
    public GameObject obj1;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {            
            StartCoroutine(Warning());
            obj1.SetActive(false);
        }
    }

    private IEnumerator Warning()
    {
        obj.SetActive(true);
        yield return new WaitForSeconds(2);
        obj.SetActive(false);
    }
}
