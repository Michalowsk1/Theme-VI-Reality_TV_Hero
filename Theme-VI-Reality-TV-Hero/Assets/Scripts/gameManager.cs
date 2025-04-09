using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class gameManager : MonoBehaviour
{

    public static Dictionary<int, string> TriviaDict = new Dictionary<int, string>();


    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject TriviaGame;
    [SerializeField] GameObject Dance;
    [SerializeField] GameObject Singing;


    [SerializeField] GameObject questionBox;
    [SerializeField] GameObject timerText;

    [SerializeField] TextMeshPro question;
    [SerializeField] GameObject answerBox;

    [SerializeField] GameObject right;
    [SerializeField] GameObject wrong;
    public static string questionNum;

    public static int keyVal;
    public static int leftOverVal;
    public static int numOfQuestions;
    void Start()
    {
        answerBox.SetActive(false);
        mainMenu.SetActive(true);
        TriviaGame.SetActive(false);
        Dance.SetActive(false);
        Singing.SetActive(false);
        question.text = "";
        leftOverVal = 1;

        right.SetActive(false);
        wrong.SetActive(false);


        TriviaDict.Add(1, "What is the capital of England?");
        TriviaDict.Add(2, "Who is going to win this contest?");
        TriviaDict.Add(3, "Where is MMU located?");
        TriviaDict.Add(4, "What game console am I inspired by?");
        TriviaDict.Add(5, "In what country has a general accidently set off a grenade in his office?");
        TriviaDict.Add(6, "What city is known as a concrete jungle?");
        TriviaDict.Add(7, "What blockly game has had a movie released about it recently?");
        TriviaDict.Add(8, "What game has arguably made a foundation for competitive speedrunning");
        TriviaDict.Add(9, "What game was rocket leagues' prequel?");
        TriviaDict.Add(10, "When was the origianl Doom released?");
        TriviaDict.Add(11, "What is the horror game about spending 5 nights somewhere");
        TriviaDict.Add(12, "What is a popular toilet reffered to in brain rot videos");
        TriviaDict.Add(13, "What popular game company made the souls-like genre");
        TriviaDict.Add(14, "What fast food restaurant is known for their Big Mac?");
        TriviaDict.Add(15, "What was the 4th game a week theme?");
        TriviaDict.Add(16, "When has the original Atari came out?");
        TriviaDict.Add(17, "What was the Call of Duty series inspired by?");
        TriviaDict.Add(18, "What is the smallest country in the world?");
        TriviaDict.Add(19, "What is the name of the official speedrunning website?");
        TriviaDict.Add(20, "Which minecraft server is arguarbly the most popular?");
        TriviaDict.Add(21, "Which main character was played the most in Resident Evil?");
        TriviaDict.Add(22, "Who is the Kratos' son in the God of War series?");
        TriviaDict.Add(23, "What DC superhero wears a bat costume?");
        TriviaDict.Add(24, "What was the recent movie that flopped for Disney?");
        TriviaDict.Add(25, "What is the hit football game series called?");

        numOfQuestions = TriviaDict.Count;
        keyVal = Random.Range(0, numOfQuestions);
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
            answerBox.SetActive(false);
            Trivia.timer = false;
        }

        if(TriviaDictionary.questionAnsweredC)
        {
            StartCoroutine(Right());
        }

        if (TriviaDictionary.questionAnsweredI)
        {
            StartCoroutine(Wrong());
        }


            if (keyVal > 25)
        {
            leftOverVal = keyVal - 25;
            keyVal = 0 + leftOverVal;
        }

        question.text = TriviaDict[keyVal]; //sets question from keyval

        questionNum = question.text; //writes question
    }

    IEnumerator Right()
    {
        right.SetActive(true);
        yield return new WaitForSeconds(1);
        right.SetActive(false);
        yield return null;
        TriviaDictionary.questionAnsweredC = false;
    }

    IEnumerator Wrong()
    {
        wrong.SetActive(true);
        yield return new WaitForSeconds(1);
        wrong.SetActive(false);
        yield return null;
        TriviaDictionary.questionAnsweredI = false;
    }
}
