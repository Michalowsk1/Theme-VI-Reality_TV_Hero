using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinalLvl : MonoBehaviour
{
    [SerializeField] GameObject timeline;
    [SerializeField] GameObject background;

    [SerializeField] GameObject gameMode;
    [SerializeField] GameObject savedSome;
    [SerializeField] GameObject savedAll;
    [SerializeField] GameObject savedNone;
    [SerializeField] GameObject mainMenu;

    [SerializeField] GameObject scoreText;
    [SerializeField] TextMeshPro scorePoints;

    public static bool game;

    public static int points;

    public static int maxPoints;

    public static bool gameOver;

    bool gameEnd;
    // Start is called before the first frame update
    void Start()
    {

        gameOver = false;
        timeline.SetActive(true);
        background.SetActive(false);
        game = false;
        scorePoints.text = "";
        scoreText.SetActive(false);

        maxPoints = 15;

        savedSome.SetActive(false);
        savedAll.SetActive(false);
        savedNone.SetActive(false);
        mainMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        StartCoroutine(IntroScene());

        if(game)
        {
            background.SetActive(true);
            scoreText.SetActive(true);
            
        }

        scorePoints.text = "Score: " + points + "/" + maxPoints;

        GameEnd();
    }

    IEnumerator IntroScene()
    {
        yield return new WaitForSeconds(28);
        game = true;
    }

    void GameEnd()
    {
        if (points == maxPoints)
        {
            gameOver = true;
            timeline.SetActive(false);
            if (points == 15)
            {
                savedAll.SetActive(true);
                gameMode.SetActive(false);
            }

            else if (points > 1 && points < 15)
            {
                savedSome.SetActive(true);
                gameMode.SetActive(false);
            }

            else if (points == 1)
            {
                savedSome.SetActive(true);
                gameMode.SetActive(false);
            }

            else if (points == 0)
            {
                savedNone.SetActive(true);
                gameMode.SetActive(false);
            }


        }

    }
}
