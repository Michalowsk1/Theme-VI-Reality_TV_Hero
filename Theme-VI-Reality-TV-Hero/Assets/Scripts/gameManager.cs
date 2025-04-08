using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject TriviaGame;
    [SerializeField] GameObject Dance;
    [SerializeField] GameObject Singing;


    [SerializeField] GameObject questionBox;
    [SerializeField] GameObject timerText;
    void Start()
    {
        mainMenu.SetActive(true);
        TriviaGame.SetActive(false);
        Dance.SetActive(false);
        Singing.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Trivia.Finished)
        {
            TriviaGame.SetActive(false);
            mainMenu.SetActive(true);
            questionBox.SetActive(false);
            timerText.SetActive(false);
            Trivia.timer = false;
        }
    }
}
