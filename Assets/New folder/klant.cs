using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class klant : MonoBehaviour
{
    public gameds pakket;
    public gameds score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (pakket.pakket == 1)
        {
            score.score += 1;
            pakket.pakket = 0;
        }
    }
}
