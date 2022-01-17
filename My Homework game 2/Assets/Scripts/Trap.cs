using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    [SerializeField] private int Damage;
    [SerializeField] private int DamageAdditional;
    [SerializeField] private int TimeC;

    private float _currentTimeIn;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            /*            
                        
             */
            
            
            var hc = other.GetComponent<HealthController>();
            hc.levelHealth -= Damage;
            Debug.Log(hc.levelHealth);
            Destroy(gameObject);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _currentTimeIn += Time.deltaTime;
            if (_currentTimeIn >= TimeC)
            {
                var hc = other.GetComponent<HealthController>();
                hc.levelHealth -= DamageAdditional;
                Debug.Log(hc.levelHealth);
                _currentTimeIn = 0;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _currentTimeIn = 0;
        }
    }
}
