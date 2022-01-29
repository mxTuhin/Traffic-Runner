using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelector : MonoBehaviour
{
    public GameObject[] cars;
    // Start is called before the first frame update
    void Start()
    {
        cars[Random.Range(0, cars.Length)].SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
