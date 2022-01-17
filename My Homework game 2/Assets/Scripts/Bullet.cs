using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]

public class Bullet : MonoBehaviour
{
    [Header("Player")]
    public Transform Player;

    [Header("Tag")]
    public string myTag = "Player";

    [Header("Demage")]
    public int demage = 3;

    [Header("Attack")]
    public AudioClip bulletAttack;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == (myTag))
        {
            GetComponent<AudioSource>().PlayOneShot(bulletAttack);
            Player.GetComponent<HealthController>().levelHealth -= demage;
            Destroy(gameObject);
            Debug.Log("Bullet attacking");
        }
    }
}

