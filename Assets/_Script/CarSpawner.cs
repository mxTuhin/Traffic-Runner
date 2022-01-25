using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] private GameObject spawnableCar;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnCar", 3,Random.Range(1.0f,2.5f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnCar()
    {
        Instantiate(spawnableCar, transform.position, Quaternion.identity);
    }
}
