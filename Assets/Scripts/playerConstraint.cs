using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerConstraint : MonoBehaviour
{
     
    public float xRange=50f;
    public float yRange=50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > xRange) 
        { 
           Vector3 newPosition = transform.position;
            newPosition.x -= 10;
            transform.position = newPosition;
        }
        if(transform.position.x<-xRange)
        {
            Vector3 newPosition = transform.position;
            newPosition.x += 10;
            transform.position = newPosition;
        }
        if(transform.position.y > yRange)
        {
            Vector3 newPosition = transform.position;
            newPosition.y-= 10;
            transform.position = newPosition;
        }
        if (transform.position.y < -yRange)
        {
            Vector3 newPosition = transform.position;
            newPosition.y += 10;
            transform.position = newPosition;
        }
    }
}
