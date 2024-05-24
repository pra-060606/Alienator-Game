using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionResolution : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] portalObject;
    public float portalWaveCounter = 0;
    public GameObject player;
    public float xRange;
    public float yRange;
    void Start()
    {
        InvokeRepeating("portalSpawner", 2, 20);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void portalSpawner()
    {
        for (int i = 0; i < portalObject.Length; i++)
        {
            portalObject[i].transform.position = new Vector3(Random.Range(-xRange, xRange), Random.Range(-yRange, yRange), 0);
        }
  
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("portal2"))
        {
            TeleportPlayerToRandomPortal(0);
        }
        else if (other.CompareTag("portal1"))
        {
            TeleportPlayerToRandomPortal(1);
        }
    }
    void TeleportPlayerToRandomPortal(int indexPortalObject)
    {
        // Choose a random portal
        GameObject randomPortal = portalObject[indexPortalObject];

        // Teleport the player to the position of the chosen portal
        player.transform.position = randomPortal.transform.position;
        portalSpawner();
    }
}
