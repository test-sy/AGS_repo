using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Action1Main : MonoBehaviour
{
    public Transform charcter;
    public Text scoreLabel;
    public Text highScore;
    private string highScoreKey = "highScore";
    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
        highScore.text = "HighScore:" + PlayerPrefs.GetInt("HighScore") + "m";
        gameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        int score = CalcScore();
           
        scoreLabel.text = "Score:" + score + "m";

        if((int)charcter.transform.position.y <= 0)
        {
            enabled = false;
            if(PlayerPrefs.GetInt("HighScore")<score)
            {
                PlayerPrefs.SetInt("HighScore", score);
            }
            gameOver.SetActive(true);

            Invoke("ReturnToTitle", 2.0f);
        }
    }

    int CalcScore()
    {
        return (int)charcter.transform.position.y;
    }

    void ReturnToTitle()
    {
        SceneManager.LoadScene("Action1title");
    }
}
