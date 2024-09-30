using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{

     System.Random rng = new System.Random();
   int max = 100;
   int min = 1;

   int raad= 0;

   int guess;
    void Start()
    {
        
        Startgame();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            lower();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            higher();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            correct();
        }

        if (raad == 5){

            verloren();

        }

    }

     void Startgame()
    {
        Debug.Log("Start Game");

        Debug.Log("Max is " + max);
        Debug.Log("Min is " + min);

        nextguess();
    }

     void nextguess()
    {
        guess = rng.Next(min, max);
        Debug.Log("Guess is  higher or lower than " + guess);
        Debug.Log("If higher press Up if lower press Down if correct press Enter");
       
    }

    void higher()
    {
        raad = raad + 1;


        min = guess;

        nextguess();

}


void lower()
{
    max = guess;

    raad = raad + 1;

    nextguess();
}

void correct()
{
    Debug.Log("gewonen!");
}

void verloren()
{
    Debug.Log("verloren");
}
}