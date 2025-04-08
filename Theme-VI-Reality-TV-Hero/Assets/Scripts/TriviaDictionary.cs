using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TriviaDictionary : MonoBehaviour
{
    public static Dictionary<int, string> TriviaDict = new Dictionary<int, string>();

    [SerializeField] TextMeshPro question;

    public static string questionNum;

    public static int numOfQuestions;

    public static bool questionAnsweredC;
    public static bool questionAnsweredI;
    // Start is called before the first frame update
    void Start()
    {
        question.text = "";
        questionAnsweredC = false;
        questionAnsweredI = false;

        addToDict();

    }

    // Update is called once per frame
    void Update()
    {

        numOfQuestions = TriviaDict.Count;
        if (Input.GetKeyUp(KeyCode.M))
        {
            question.text = TriviaDict[Random.Range(1, numOfQuestions)];
        }
        questionNum = question.text;
    }

    public void Correct()
    {
        HUD.score += 10;
        question.text = TriviaDict[Random.Range(1, numOfQuestions)];
        questionAnsweredC = true;
        
    }

    public void InCorrect()
    {
        HUD.score -= 5;
        question.text = TriviaDict[Random.Range(1, numOfQuestions)];
        questionAnsweredI = true;
    }

    public void addToDict()
    {
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
    }
}


