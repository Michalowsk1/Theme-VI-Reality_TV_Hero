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

    public static int fameLvl;

    public static int score;

    public static int scoreDisplay;

    public static int finalScore;

    public static int finalDanceScore;

    public static int finalSingingScore;

    DateTime curretTime;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        slider.value = 0;
        slider.maxValue = 10;
        fameLvl = 1;

        scoreDisplay = 0;

    }

    // Update is called once per frame
    void Update()
    {
        Clock();

        if (Trivia.Finished|| Dance.finished || Singing.finished)
        {
            xpUpdate();
        }

        maxXpInc();

    }


    void Clock()
    {
        curretTime = DateTime.Now;
        hour = curretTime.Hour.ToString();
        minute = curretTime.Minute.ToString();

        Time.text = hour + ":" + minute;
    }
   


    void xpUpdate()
    {
        for (int i = 0; i < finalScore; i++)
        {
            slider.value += 1f;
        }

        for (int i = 0; i < finalDanceScore; i++)
        {
            slider.value += 0.05f;
        }

        for (int i = 0; i < finalSingingScore; i++)
        {
            slider.value += 0.01f;
        }

        if (scoreDisplay < -100)
        {
            scoreDisplay = -100;
        }


        scoreDisplay += score;
        scoreDisplay += Dance.score;
        Score.text = "Score:" + scoreDisplay;
        finalScore = 0;
        score = 0;
        finalDanceScore = 0;
        finalSingingScore = 0;
        Trivia.Finished = false;
        Dance.finished = false;
        Singing.finished = false;
        Dance.score = 0;
        
    }

    void maxXpInc()
    {

        if (slider.value >= slider.maxValue)
        {
            
            fameLvl++;
            Fame.text = "Fame:" + fameLvl;
            slider.maxValue = 10 + (fameLvl * 5);
            slider.value = 0.0f;

        }

    }
}
