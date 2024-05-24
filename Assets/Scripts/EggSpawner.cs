using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject eggPrefab;
    private float eggSpawnRangeX = 14f;
    private float eggSpawnRangeY = 11f;
    private Vector3 randomLocation;
    void Start()
    {
        InvokeRepeating("spawnEggs", 2, 60);
    }

    // Update is called once per frame
    void Update()
    {
        randomLocation =new(Random.Range(eggSpawnRangeX,-eggSpawnRangeX),Random.Range(eggSpawnRangeY,-eggSpawnRangeY));
    }

    void spawnEggs()
    {
        Instantiate(eggPrefab,randomLocation,transform.rotation);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(eggPrefab);
        }
    }
}
