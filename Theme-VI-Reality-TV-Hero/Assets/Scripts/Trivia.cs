using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Trivia : MonoBehaviour
{
    [SerializeField] GameObject level;
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject questionBox;
    string question;
    void Start()
    {
        questionBox.SetActive(false);
    }

    void Update()
    {
        StartCoroutine(cutscene());
        question = TriviaDictionary.questionNum;

        QandAs();
        quitButton();

    }

    IEnumerator cutscene()
    {
        yield return new WaitForSeconds(10);
        questionBox.SetActive(true);
    }

    void quitButton()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            mainMenu.SetActive(true);
            level.SetActive(false);

        }
    }

    void QandAs()
    {
        switch (question)
        {
            case "What is the capital of England?":

                Debug.Log("London");
                break;

            case "Who is going to win this contest?":

                Debug.Log("MEEEEEEEE");
                break;

            case "Where is MMU located?":

                Debug.Log("Manchester");
                break;

            case "What game console am I inspired by?":

                Debug.Log("Atari");
                break;

            case "In what country has a general accidently set off a grenade in his office?":

                Debug.Log("Poland");
                break;

            case "What city is known as a concrete jungle?":

                Debug.Log("New York City");
                break;

            case "What blockly game has had a movie released about it recently?":

                Debug.Log("A Minecraft Movie");
                break;

            case "What game has arguably made a foundation for competitive speedrunning":

                Debug.Log("Quake done quick");
                break;

            case "What game was rocket leagues' prequel?":

                Debug.Log("Supersonic Acrobatic Rocket-Powered Battle-Cars");
                break;

            case "When was the origianl Doom released?":

                Debug.Log("1995");
                break;

            case "What is the horror game about spending 5 nights somewhere":

                Debug.Log("Five Nights at Freddys");
                break;

            case "What is a popular toilet reffered to in brain rot videos":

                Debug.Log("Skibidi Toilet");
                break;

            case "What popular game company made the souls-like genre":

                Debug.Log("FromSoft");
                break;

            case "What fast food restaurant is known for their Big Mac?":

                Debug.Log("McDonalds");
                break;

            case "What was the 4th game a week theme?":

                Debug.Log("PuzzleBox");
                break;

            case "When has the Atari came out?":

                Debug.Log("1995");
                break;

            case "What was the Call of Duty series inspired by?":

                Debug.Log("1995");
                break;

            case "What is the smallest country in the world?":

                Debug.Log("1995");
                break;

            case "What is the name of the official speedrunning website?":

                Debug.Log("1995");
                break;

            case "Which minecraft server is arguarbly the most popular?":

                Debug.Log("Hypixel");
                break;

            case "Which main character was played the most in Resident Evil?":

                Debug.Log("Chris Redfield");
                break;

            case "Who is the Kratos' son in the God of War series?":

                Debug.Log("Atreus");
                break;

            case "What DC superhero wears a bat costume?":

                Debug.Log("Batman");
                break;

            case "What was the recent movie that flopped for Disney?":

                Debug.Log("Snow White");
                break;

            case "What is the hit football game series called?":

                Debug.Log("FIFA");
                break;
        }
    }
}
