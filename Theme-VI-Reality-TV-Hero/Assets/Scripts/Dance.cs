using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class Dance : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI TimeText;


    [SerializeField] GameObject DanceScreen;
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject timeline;

    [SerializeField] public static GameObject spawnedArrow;

    [SerializeField] GameObject[] arrows;

    [SerializeField]  GameObject ScreenTime;

    public Transform[] spawn;

    public static int score;

    int finalScore;

    public static int stage;

    public static int randInt;

    public static float gravScale;

    public float timer;
    float maxTime;

   public static int timeLeftInt;
    public float timeLeftFloat;

    public static bool game;

    public static bool finished;



    void Start()
    {
        ScreenTime.SetActive(false);
        timeline.SetActive(false);
        ScreenTime.SetActive(false);

        maxTime = 1.0f;

        game = false;

        finished = false;

        scoreText.text = "";

        timeLeftInt = 30;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Cutscene());

            scoreText.text = "Score: " + score / 10;
            stageSwitcher();

            TimerCountDown();

            randInt = Random.Range(0, 4);
            timeLeftFloat += Time.deltaTime;

            timer = timer + Time.deltaTime;

        if(game)
        {
            TimerCountDown();
            arrowSpawner();
            GameEnd();
        }

    }

    void stageSwitcher()
    {
        if (score >= 0)
        {
            stage = 1;
            maxTime = 1.0f;
            gravScale = .8f;
        }
        if (score >= 100)
        {
            stage = 2;
            maxTime = 0.85f;
            gravScale = .9f;
        }

        if (score >= 250)
        {
            stage = 3;
            maxTime = 0.6f;
            gravScale = 1f;
        }

        if (score >= 500)
        {
            stage = 4;
            maxTime = 0.45f;
            gravScale = 1.1f;
        }
    }

    void arrowSpawner()
    {
        if(timer >= maxTime)
        {
            spawnedArrow = Instantiate(arrows[randInt], spawn[randInt].position, arrows[randInt].transform.rotation);
            timer = 0.0f;
        }
    }

    void TimerCountDown()
    {
        if (timeLeftFloat >= 1)
        {
            timeLeftInt--;
            timeLeftFloat = 0;
        }

        TimeText.text = "Time Left:" + timeLeftInt.ToString();

    }

    void GameEnd()
    {
        if(timeLeftInt <= 0)
        {
            game = false;
            finished = true;
            timeline.SetActive(true);
            ScreenTime.SetActive(false);
            scoreText.text = "";
            DanceScreen.SetActive(false);
            mainMenu.SetActive(true);

            finalScore = score / 10;

            HUD.finalDanceScore = score;
            finalScore = 0;
            
        }
    }


    IEnumerator Cutscene()
    {
        timeline.SetActive(true);
        yield return new WaitForSeconds(10.5f);
        timeline.SetActive(false);
        ScreenTime.SetActive(true);
        game = true;
        yield return null;

    }

}
