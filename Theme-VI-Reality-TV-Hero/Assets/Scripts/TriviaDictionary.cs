using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class TriviaDictionary : MonoBehaviour
{
    public static Dictionary<int, string> Trivia = new Dictionary<int, string>();

    [SerializeField] TextMeshPro question;

    public static string questionNum;

    public static int numOfQuestions;
    // Start is called before the first frame update
    void Start()
    {
        question.text = "";

        Trivia.Add(1, "What is the capital of England?");
        Trivia.Add(2, "Who is going to win this contest?");
        Trivia.Add(3, "Where is MMU located?");
        Trivia.Add(4, "What game console am I inspired by?");
        Trivia.Add(5, "In what country has a general accidently set off a grenade in his office?");
        Trivia.Add(6, "What city is known as a concrete jungle?");
        Trivia.Add(7, "What blockly game has had a movie released about it recently?");
        Trivia.Add(8, "What game has arguably made a foundation for competitive speedrunning");
        Trivia.Add(9, "What game was rocket leagues' prequel?");
        Trivia.Add(10, "When was the origianl Doom released?");
        Trivia.Add(11, "What is the horror game about spending 5 nights somewhere");
        Trivia.Add(12, "What is a popular toilet reffered to in brain rot videos");
        Trivia.Add(13, "What popular game company made the souls-like genre");
        Trivia.Add(14, "What fast food restaurant is known for their Big Mac?");
        Trivia.Add(15, "What was the 4th game a week theme?");
        Trivia.Add(16, "When has the Atari came out?");
        Trivia.Add(17, "What was the Call of Duty series inspired by?");
        Trivia.Add(18, "What is the smallest country in the world?");
        Trivia.Add(19, "What is the name of the official speedrunning website?");
        Trivia.Add(20, "Which minecraft server is arguarbly the most popular?");
        Trivia.Add(21, "Which main character was played the most in Resident Evil?");
        Trivia.Add(22, "Who is the Kratos' son in the God of War series?");
        Trivia.Add(23, "What DC superhero wears a bat costume?");
        Trivia.Add(24, "What was the recent movie that flopped for Disney?");
        Trivia.Add(25, "What is the hit football game series called?");
    }

    // Update is called once per frame
    void Update()
    {
        numOfQuestions = Trivia.Count ;
        if (Input.GetKeyUp(KeyCode.M))
        {
            question.text = Trivia[Random.Range(1, numOfQuestions)];
        }
        questionNum = question.text;
    }
}


