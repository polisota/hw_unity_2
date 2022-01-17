using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (AudioSource))]
[RequireComponent (typeof (Rigidbody))]

public class Enemy : MonoBehaviour
{
    [Header("Player")]
    public Transform Player;

    [Header("Attack")]
    public AudioClip enemyAttack;

    [Header("Tag")]
    public string myTag = "Player";

    [Header("Damage")]
    public int damage = 10;

    public float seeDistance = 25f;    
    public float attackDistance = 2f;    
    public float speed = 2;   
    private Transform target;

    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, target.transform.position) < seeDistance)
        {
            if (Vector3.Distance(transform.position, target.transform.position) > attackDistance)
            {                
                transform.LookAt(target.transform);
                transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
            }
        }
        else
        {
           
        }
    }

    void OnTriggerEnter (Collider collider)
    {
        if (collider.tag == (myTag))
        {
            GetComponent<AudioSource>().PlayOneShot(enemyAttack);
            Player.GetComponent<HealthController>().levelHealth -= damage;
            Debug.Log("Enemy attacking");
        }
    }
}
