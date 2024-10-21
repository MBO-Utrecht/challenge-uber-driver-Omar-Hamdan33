using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class klantdesscript : MonoBehaviour
{ 
  public float score = 0;
     public float textscore;
    public klantscript klant;
    public klantscript klanttspawn ;
    public klantscript soortklant2;
    
    void Start()
    {
       if (textscore == null) {
         
        

        // Zet de initiële score naar 0
        textscore = 0;
       }
    }

    // Update is called once per frame
    void Update()
    {
      

       textscore =  score;
        if (klant.soortklant2 == 7){
            transform.position = new Vector3 (-16.08f, -10000.81f , 0);
        }
          
        if (klant.klant == 2) {
       
        if (klant.soortklant2 == 1){
      
transform.position = new Vector3 (-16.08f, -10.81f , 0);
klant.soortklant2 = 0;
klant.klanttspawn =1;
} else if (klant.soortklant2 == 2){
transform.position = new Vector3 (10f, -11f, 0);
klant.soortklant2 = 0;
klant.klanttspawn = 2;
} else if (klant.soortklant2 == 3){
transform.position = new Vector3 (8.74f, 17.12f, 0);
klant.soortklant2 = 0;
klant.klanttspawn = 3;
} else if (klant.soortklant2 == 4){
transform.position = new Vector3 (-17.39f, 17.23f, 0);
klant.soortklant2 = 0;
klant.klanttspawn = 4;
} else if (klant.soortklant2 == 5){
transform.position = new Vector3 (-17.39f, -10.81f, 0);
klant.soortklant2 = 0;
klant.klanttspawn = 5;
} else if (klant.soortklant2 == 6){
transform.position = new Vector3 (7.3f, 43.6f, 0);
klant.soortklant2 = 0;
klant.klanttspawn = 6;
}
    }
}
    void OnCollisionEnter2D(Collision2D col) 
{ 
    
  { 
    klant.soortklant2 = 7;
  klant.klant = 0;
  score ++;
  Debug.Log("Collided with de objectief ");
  Debug.Log(score);
  }
  }

} 

    

