using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeeseTrap : MonoBehaviour
{
    public GameObject obj;   

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Trap());            
        }
    }

    private IEnumerator Trap()
    {
        yield return new WaitForSeconds(2);
        obj.SetActive(true);
    }
}
