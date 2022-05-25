using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    bool stopwatchactive = false;
    float Currenttime;
    public Text currenttimetext;
    int score;
    public Text textscore;

void Start()
    {
        Currenttime = 0;
    }
     void Update()
    {
       //if (stopwatchactive == true)
        {
            //Currenttime = Currenttime + Time.deltaTime;
        }
        //TimeSpan time = TimeSpan.FromSeconds(Currenttime);
       // currenttimetext.text = time.ToString(@"mm\:ss\:fff");
    }
}

