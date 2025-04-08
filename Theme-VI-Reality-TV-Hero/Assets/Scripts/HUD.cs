using System;
using TMPro;
using UnityEngine;

public class HUD : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Time;
    [SerializeField] TextMeshProUGUI Score;
    [SerializeField] TextMeshProUGUI xpPercentage;

    string hour, minute;
    public static int score;
    DateTime curretTime;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Clock();
        ScoreText();
    }


    void Clock()
    {
        curretTime = DateTime.Now;
        hour = curretTime.Hour.ToString();
        minute = curretTime.Minute.ToString();

        Time.text = hour + ":" + minute;
    }
    
    void ScoreText()
    {
        Score.text = "Score:" + score;
    }
}
