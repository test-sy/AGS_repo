using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Action1Main : MonoBehaviour
{
    public Transform charcter;
    public Text scoreLabel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int score = CalcScore();
        scoreLabel.text = "Score:" + score + "m";
    }

    int CalcScore()
    {
        return (int)charcter.transform.position.y;
    }
}
