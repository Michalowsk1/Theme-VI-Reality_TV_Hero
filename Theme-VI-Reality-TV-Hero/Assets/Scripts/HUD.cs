using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class HUD : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Time;
    [SerializeField] TextMeshProUGUI Score;
    [SerializeField] TextMeshProUGUI Fame;
    [SerializeField] TextMeshProUGUI xpPercentage;

    [SerializeField] GameObject expBar;
    string hour, minute;
    public static int score;
    float xp;
    int fameLvl;
    DateTime curretTime;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        xp = 0;
        fameLvl = 1;
        expBar.transform.localScale = new Vector2(expBar.transform.localScale.x, expBar.transform.localScale.y);
    }

    // Update is called once per frame
    void Update()
    {
        Clock();
        ScoreText();
        Experience();
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

    void Experience()
    {
        expBar.transform.localScale = new Vector2(expBar.transform.localScale.x + xp, expBar.transform.localScale.y);

        //TEST
        if (Input.GetKey(KeyCode.Mouse0))
        {
            xp = 0.01f/20;
        }
        else
        {
            xp = 0;
        }

        //INCREASES LVL
        if (expBar.transform.localScale.x >= 0.8f)
        {
            fameLvl++;
            expBar.transform.localScale = new Vector2(0.01f, expBar.transform.localScale.y);
        }

        Fame.text = "Fame:" + fameLvl;
    }
}
