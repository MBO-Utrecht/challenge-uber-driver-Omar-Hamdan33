using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasController : MonoBehaviour
{
    public klantdesscript score;
    public carscript stop;
    public TMP_Text scoretext; 
    public TMP_Text gameovertext;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(gameover());
    }

    // Update is called once per frame
    void Update()
    {
           
            scoretext.text = "Score: " + score.score;
    }
    IEnumerator gameover()
    {
        yield return new WaitForSeconds(30); 
        gameovertext.text = "Game Over";
        stop.stop = 1;
    }
}
