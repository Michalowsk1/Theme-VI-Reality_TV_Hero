using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class Dance : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;

    [SerializeField] GameObject[] arrows;

    public Transform[] spawn;

    public static int score;

    public static int stage;

    int randInt;

    float timer;
    float maxTime;
    void Start()
    {
        maxTime = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
        stageSwitcher();

        randInt = Random.Range(0, 3);

        timer = timer + Time.deltaTime;

        arrowSpawner();

    }

    void stageSwitcher()
    {
        if (score >= 0)
        {
            stage = 1;
            maxTime = 1.0f;
        }
        if (score >= 10)
        {
            stage = 2;
            maxTime = 1;
        }

        if (score >= 25)
        {
            stage = 3;
            maxTime = 0.9f;
        }

        if (score >= 50)
        {
            stage = 4;
            maxTime = 0.8f;
        }
    }

    void arrowSpawner()
    {
        if(timer >= maxTime)
        {
            Instantiate(arrows[randInt], spawn[randInt].position, arrows[randInt].transform.rotation);
            timer = 0.0f;
        }
    }
}
