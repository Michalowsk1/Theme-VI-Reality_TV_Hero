using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinalLvl : MonoBehaviour
{
    [SerializeField] GameObject timeline;
    [SerializeField] GameObject background;

    [SerializeField] GameObject scoreText;
    [SerializeField] TextMeshPro scorePoints;

    public static bool game;

    public static int points;
    // Start is called before the first frame update
    void Start()
    {
        //timeline.SetActive(true);
        background.SetActive(false);
        //game = false;
        game = true;
        scorePoints.text = "";
        scoreText.SetActive(false);
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

        scorePoints.text = "Score: " + points + "/15";
    }

    IEnumerator IntroScene()
    {
        yield return new WaitForSeconds(28);
        game = true;
    }

    void GameEnd()
    {
        if(points == 15)
        {
            Debug.Log("GAMEWON");
        }
    }

}
