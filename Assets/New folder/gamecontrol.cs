using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontrol : MonoBehaviour
{
    public float time = 30f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time-=Time.deltaTime;
        
        if (time<=0)
        {
            Debug.Log("game over");
        }
    }
}
