using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ShootingMechanics : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletPrefab;
    public Transform shootingPoint;
    public GameObject referenceObject;
    private Vector3 direction;
    public float bulletSpeed = 10f;
    void Start()
    {
         
        
    }

    // Update is called once per frame
    void Update()
    {
       // if (Input.GetKey(KeyCode.Space))
        //{
          //  Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);

            
        //}
        //directionOfBullet();
    }
    void directionOfBullet()
    {
        direction = referenceObject.transform.position - shootingPoint.position;
        direction.Normalize();
       
        bulletPrefab.GetComponent<Rigidbody>().AddForce(Time.deltaTime * bulletSpeed * direction,ForceMode.Impulse);
    }


}
