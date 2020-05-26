using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Action1Main : MonoBehaviour
{
    public Transform charcter;
    public Text scoreLabel;
    public Text highScore;
    public int timeCount = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeCount++;
        int score = CalcScore();
        int highscore = 0;
        if (highscore <= score || timeCount >= 100)
        {
            highscore = score;
            highScore.text = "HighScore:" + highscore + "m";
            timeCount = 0;
        }
           
        scoreLabel.text = "Score:" + score + "m";
        
        
    }

    int CalcScore()
    {
        return (int)charcter.transform.position.y;
    }
}
