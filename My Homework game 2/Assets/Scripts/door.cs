using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    //public Item item;
    public GameObject dr;
    public GameObject obj;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var inv = other.GetComponent<Inventory>();
            if (inv.GetItem(1))
            {
                dr.GetComponent<Animator>().enabled = true;
            }
            else
            {
                StartCoroutine(Warning());
            }

        }
    }

    private IEnumerator Warning()
    {
        obj.SetActive(true);
        yield return new WaitForSeconds(2);
        obj.SetActive(false);
    } 
}
