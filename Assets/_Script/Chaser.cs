using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : MonoBehaviour
{
    public float speed = 20.0f;
    public float minDist = 1f;
    public Vector3 target;

    // Use this for initialization
    void Start ()
    {
        target = transform.position + new Vector3(0, 0, 107.0f);
    }
	
    // Update is called once per frame
    void Update () 
    {
        
        //get the distance between the chaser and the target
        float distance = Vector3.Distance(transform.position,target);
        print(distance);

        //so long as the chaser is farther away than the minimum distance, move towards it at rate speed.
        if (distance > minDist)
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
            
        
    }

    
}
