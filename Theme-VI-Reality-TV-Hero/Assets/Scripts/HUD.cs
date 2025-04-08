using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Time;
    [SerializeField] TextMeshProUGUI Score;
    [SerializeField] TextMeshProUGUI Fame;


    [SerializeField] Slider slider;

    string hour, minute;

    int fameLvl;

    public static int score;

    public static int finalScore;
    DateTime curretTime;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        slider.value = 0;
        slider.maxValue = 10;
        fameLvl = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Clock();
        ScoreText();

        if (Trivia.Finished)
        {
            xpUpdate();
        }

        maxXpInc();

        Debug.Log("Score: " + score + "       FinalScore: " + finalScore + "   Sliderval: " + slider.value);
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


    void xpUpdate()
    {
        for (int i = 0; i < finalScore; i++)
        {
            slider.value += 1f;
        }
        finalScore = 0;
        //score = 0;
        Trivia.Finished = false;
    }

    void maxXpInc()
    {
        float leftover;
        if (slider.value >= slider.maxValue)
        {
            leftover = slider.value - slider.maxValue;
            fameLvl++;
            slider.value = 0.0f + leftover;
            Fame.text = "Fame:" + fameLvl;
        }

        slider.maxValue = 10 + (fameLvl * 5);
    }
}
