using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform Player;
    public string myTag = "Player";
    public int demage;   
    
    void Update()
    {
        transform.LookAt (Player);     
    }

    void OnTriggerEnter (Collider collider)
    {
        if (collider.tag == (myTag))
        {
            Player.GetComponent<HealthController>().CurrentHealth -= demage;
        }
    }
}
