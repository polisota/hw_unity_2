using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class AppleSpawn : MonoBehaviour
{    
    //public Transform[] SpawnPoints;
    public GameObject[] PrefabForSpawn;
    public int amount;
    public int yieldTimeMin;
    public int yieldTimeMax;

    
    void Start()
    {
        StartCoroutine (SpawnRandom());
    }

    public IEnumerator SpawnRandom()
    {
        for (int i = 0; i < amount; i++)
        {
            yield return new WaitForSeconds(Random.Range(yieldTimeMin, yieldTimeMax));

            GameObject obj = PrefabForSpawn[Random.Range(0, PrefabForSpawn.Length)];
            //Transform pos = SpawnPoints[Random.Range(0, SpawnPoints.Length)];
            //Vector3 randomPosition = new Vector3(Random.Range(transform.position.x - spawnRange, transform.position.x + spawnRange),
            int x = Random.Range(13, -101);
            int z = Random.Range(15, -136);
            Vector3 randomPosition = new Vector3(x, 2, z);

            var newobj = Instantiate(obj, randomPosition, Quaternion.identity);
            Debug.Log(obj.name);
        }
    }

    /*     
    public Transform[] SpawnPoints;
    public GameObject[] PrefabForSpawn;
    public int amount;
    public int yieldTimeMin;
    public int yieldTimeMax;

    
    void Start()
    {
        Spawn();
    }

    public IEnumerator Spawn()
    {
        for (int i = 0; i < amount; i++)
        {
            yield return new WaitForSeconds(Random.Range(yieldTimeMin, yieldTimeMax));

            GameObject obj = PrefabForSpawn[Random.Range(0, PrefabForSpawn.Length)];
            Transform pos = SpawnPoints[Random.Range(0, SpawnPoints.Length)];
            //Vector3 randomPosition = new Vector3(Random.Range(transform.position.x - spawnRange, transform.position.x + spawnRange),
            int x = Random.Range(pos.position.x);
            int z = Random.Range(pos.position.z);
            Vector3 randomPosition = new Vector3(x, 1, z);

            var newobj = Instantiate(obj, randomPosition, Quaternion.identity);
            Debug.Log(obj.name);
        }
    }





    void SpawnRandom()
    {
        for (int i = 0; i < amount; i++)
        {
            //yield return new WaitForSeconds(Random.Range(yieldTimeMin, yieldTimeMax));

            GameObject obj = PrefabForSpawn[Random.Range(0, PrefabForSpawn.Length)];
            //Transform pos = SpawnPoints[Random.Range(0, SpawnPoints.Length)];
            //Vector3 randomPosition = new Vector3(Random.Range(transform.position.x - spawnRange, transform.position.x + spawnRange),
            int x = Random.Range(13, -101);
            int z = Random.Range(15, -136);
            Vector3 randomPosition = new Vector3(x, 1, z);

            var newobj = Instantiate(obj, randomPosition, Quaternion.identity);
            Debug.Log(obj.name);
        }
    }
     */
}
