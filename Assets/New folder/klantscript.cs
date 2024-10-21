using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class klantscript : MonoBehaviour
{
    System.Random rng = new System.Random();
    public float klant = 0;
    public float soortklant = 0;
    public  float soortklant2 = 0;
    float klant2 = 0;
    public float klanttspawn = 0;
    void Start()
    {
       float klant = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        if (klant == 0)
        { soortklant = rng.Next(1, 6);
         klant = 1;
         Debug.Log(soortklant);
         if (soortklant == klanttspawn){
            klant = 0;
         }

         }

         if (soortklant == 1){
            transform.position = new Vector3 (-16.08f, -10.81f , 0);
            soortklant = 0;
            klant2 = 1;
         } else if (soortklant == 2){
            transform.position = new Vector3 (10f, -11f, 0);
            soortklant = 0;
            klant2 = 2;
         } else if (soortklant == 3){
            transform.position = new Vector3 (8.74f, 17.12f, 0);
            transform.Rotate(0, 0, 180);
            soortklant = 0;
            klant2 = 3;
         } else if (soortklant == 4){
            transform.position = new Vector3 (-17.39f, 17.23f, 0);
            transform.Rotate(0, 0, 180);
            soortklant = 0;
            klant2 = 4;
         } else if (soortklant == 5){
            transform.position = new Vector3 (-17.39f, -10.81f, 0);
            soortklant = 0;
            klant2 = 5;
         } else if (soortklant == 6){
            transform.position = new Vector3 (7.3f, 43.6f, 0);
            transform.Rotate(0, 0, 270);
            soortklant = 0; 
            klant2 = 6;
         } if (soortklant == 7){
            transform.position = new Vector3 (0, 1000, -90);
         }


            if (klant2 == 1 ) {
soortklant = rng.Next(2, 6);

 }
         
else if (klant2 == 2){
soortklant2 = rng.Next(2, 6); 
if ( soortklant2 == 2f ) { 
   soortklant2 = 1f;
   };
   klant2 = 0;

}
else if (klant2 == 3){
soortklant2 = rng.Next(2, 6); 
if ( soortklant2 == 3f ) { 
   soortklant2 = 1f;
   };
   klant2 = 0;
}
else if (klant2 == 4){
soortklant2 = rng.Next(2, 6); 
if ( soortklant2 == 4f ) { 
   soortklant2 = 1f;
   };
   klant2 = 0;
}
else if (klant2 == 5){
soortklant2 = rng.Next(2, 6); 
if ( soortklant2 == 5f ) { 
   soortklant2 = 1f;
   };
   klant2 = 0;
}
else if (klant2 == 6){
soortklant2 = rng.Next(2, 6); 
if ( soortklant2 == 6f ) { 
   soortklant2 = 1f;
   };
   klant2 = 0;
}
   
   
    } 




  void OnCollisionEnter2D(Collision2D col) 
{
 
  { soortklant = 7;
  klant = 2;
  Debug.Log("Collided with de klant ");}

} 
}
//customer 1 -16.08 , -10.81 , 0
//customer 2 10 , -11 , 0
//customer 3 8.74 , 17.12 , 0 rotate 180
//customer 4 -17.39 , 17.23 , 0 rotate 180
//customer 5 -17.39 , -10.81 , 0
//customer 6  7.3, 43.6 , 0 rotate 270



