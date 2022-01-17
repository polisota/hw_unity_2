using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Turrel : MonoBehaviour
{
    [SerializeField] private GameObject Bullet;
    [SerializeField] private float Force;
    public UnityEvent OnPlayerEnter;

    private Vector3 _playerPosition;
    private bool _isPlyaerInside;

    private float coolDown = 3f;
    private float currentTime = 0;

    void Start()
    {
        StartCoroutine(BulleySpawn(coolDown));
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _playerPosition = other.gameObject.transform.position;
            _isPlyaerInside = true;
            OnPlayerEnter.Invoke();
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            _playerPosition = other.gameObject.transform.position;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _isPlyaerInside = false;
        }
    }

    IEnumerator BulleySpawn(float spawnTime)
    {
        while (true)
        {
            if (_isPlyaerInside)
            {
                var bulletGo = Instantiate(Bullet, transform.position, Quaternion.identity).GetComponent<Rigidbody>();
                bulletGo.AddForce((_playerPosition - transform.position) * Force, ForceMode.Impulse);
            }

            yield return new WaitForSeconds(spawnTime);
        }
    }

    public void BulletSpawn()
    {
        var bulletGo = Instantiate(Bullet, transform.position, Quaternion.identity).GetComponent<Rigidbody>();
        bulletGo.AddForce((_playerPosition - transform.position) * Force, ForceMode.Impulse);
    }
}