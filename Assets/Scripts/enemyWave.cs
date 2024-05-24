using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyWave : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyObjectPrefabs;
    private float waveNumber=0f;
    private float timeElapsed=0f;
    private float waveInterval=45f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if(timeElapsed > waveInterval)
        {
            Vector3 spawnPosition =new(0, 0, 0);
            Instantiate(enemyObjectPrefabs,spawnPosition,transform.rotation);
            timeElapsed = 0f;
            waveNumber++;
        }
    }
}
