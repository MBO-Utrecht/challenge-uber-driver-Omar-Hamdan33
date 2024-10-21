using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followcar : MonoBehaviour
{
    public GameObject car;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 ( car.transform.position.x, car.transform.position.y, transform.position.z); 
    }
}
