using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carscript : MonoBehaviour
{
  public float speed = 0;
  public float soortklant = 0;
  public float soortklant2 = 0;
  public float stop = 0;

 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
  if (stop == 1) {
    speed = 0;
  } else{
       if (speed >0.9) 
  { speed =1; }
  else if (speed > 0.5)
  {
    speed  =  speed +(0.002f * Time.deltaTime );
  } else if (speed > 0.3){
    speed  =  speed +(0.003f * Time.deltaTime );
  } else if (speed > 0.1){
    speed  =  speed +(0.004f * Time.deltaTime );
  } else {
    speed  =  speed +(0.005f * Time.deltaTime );
  } 
    
    // deze zijn soort van admin tools
    if (Input.GetKey(KeyCode.UpArrow))
    {speed = 0.1f;}

    if (Input.GetKey(KeyCode.Space))
    {speed = 0;}


        
    if (Input.GetKey(KeyCode.LeftArrow))
    {
         transform.Rotate(0, 0, 90 * Time.deltaTime);
    }

    if (Input.GetKey(KeyCode.RightArrow))
    { 
        transform.Rotate(0, 0, -90 * Time.deltaTime);}

    

    if (Input.GetKey(KeyCode.DownArrow))
    { if (speed < -0.9) 
  { speed = -1; }
  else if (speed < -0.5) 
  speed  =  speed - (0.003f * Time.deltaTime ) ;
  else if (speed < -0.3)
  speed  =  speed - (0.005f * Time.deltaTime ) ;
  else if (speed < -0.1)
  speed  =  speed - (0.008f * Time.deltaTime ) ;
  else
  {
    speed  =  speed - (0.01f * Time.deltaTime ) ;
  } } 

     transform.Translate(0, speed , 0);
     //Debug.Log(speed);
  }
    }
    

void OnCollisionEnter2D(Collision2D col) 
{
  if (col.gameObject.name == "Hexagon Pointed-Top")
  {}
  else if (col.gameObject.name == "Customer")
  {} else{
   speed = -0.01f;
    Debug.Log("Collided with " + col.gameObject.name);
  }
}


}
