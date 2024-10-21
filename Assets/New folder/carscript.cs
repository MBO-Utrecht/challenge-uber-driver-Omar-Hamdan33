using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carscript : MonoBehaviour
{
    public float speed = 0.0f;
    public float stop = 0;
    public float draai  = 1.0f;

  // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (stop == 1)
        {
            speed = 0.0f; 
        } 
        else {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            speed = 0.2f;
           
        }
        else if (Input.GetKey(KeyCode.DownArrow)|| Input.GetKey(KeyCode.S))
        {
            speed = -0.1f;
        }
        transform .Translate(0, speed, 0);


        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, draai );
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -draai );
        }
    }
    }

  void OnCollisionEnter2D(Collision2D col)
{
    Debug.Log("Collided with " + col.gameObject.name);
    speed = -0.1f; 
    StartCoroutine(ResetSpeed()); 
}

IEnumerator ResetSpeed()
{
    yield return new WaitForSeconds(0.2f); 
    speed = 0;
}

}
