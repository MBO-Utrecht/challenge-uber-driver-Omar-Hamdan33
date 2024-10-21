using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pakketje : MonoBehaviour
{
    public klant pakket;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (pakket.pakket.pakket == 0f)
        {
            transform.Translate(0, 1000, 0);
            pakket.pakket.pakket = 1f;
        }
    }
}
