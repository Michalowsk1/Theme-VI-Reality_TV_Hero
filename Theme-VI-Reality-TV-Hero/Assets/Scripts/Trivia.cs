using System.Collections;
using TMPro;
using UnityEngine;

public class Trivia : MonoBehaviour
{
    [SerializeField] GameObject level;
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject questionBox;
    [SerializeField] GameObject answerBox;
    [SerializeField] GameObject timerText;
    [SerializeField] TextMeshProUGUI Fame;
    [SerializeField] TextMeshProUGUI timeText;
    [SerializeField] GameObject[] questions;
    string question;
    int fameLvl;

    public static bool Finished;

    float timeLeftFloat;
    public static int timeLeftInt;

    public static bool timer;


    void Start()
    {
        timerText.SetActive(false);
        answerBox.SetActive(false);
        Finished = false;
        timer = false;
        timeLeftInt = 20;
        questionBox.SetActive(false);
        for (int i = 0; i < questions.Length; i++)
        {
            questions[i].SetActive(false);
        }

        timeText.text = "Time Left: 20";
        
    }

    void Update()
    {
        StartCoroutine(cutscene());
        question = gameManager.questionNum;
        QandAs();
        quitButton();
        FinalScore();


        if (timer)
        {
            TimerCountDown();
        }
    }

    IEnumerator cutscene()
    {
        yield return new WaitForSeconds(10);
        questionBox.SetActive(true);
        timerText.SetActive(true);
        answerBox.SetActive(true);
        timer = true;
    }

    void quitButton()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            mainMenu.SetActive(true);
            level.SetActive(false);

        }
    }

    void QuestionClearer()
    {

        for (int i = 0; i < questions.Length; i++)
        {
            questions[i].SetActive(false);
        }     
    }

    void FinalScore()
    {
        if(timeLeftInt <= 0)
        {
            Finished = true;
            HUD.finalScore = HUD.score / 10;
        }
    }


    void TimerCountDown()
    {
        timeLeftFloat += Time.deltaTime;
        if (timeLeftFloat >= 1)
        {
            timeLeftInt--;
            timeLeftFloat = 0;
        }

        timeText.text = "Time Left:" + timeLeftInt.ToString();

    }
    void QandAs()
    {
        QuestionClearer();
        switch (question)
        {
            
            case "What is the capital of England?":
                QuestionClearer();
                questions[0].SetActive(true);
                break;

            case "Who is going to win this contest?":

                QuestionClearer();
                questions[1].SetActive(true);
                break;

            case "Where is MMU located?":

                QuestionClearer();
                questions[2].SetActive(true);
                break;

            case "What game console am I inspired by?":

                QuestionClearer();
                questions[3].SetActive(true);
                break;

            case "In what country has a general accidently set off a grenade in his office?":

                QuestionClearer();
                questions[4].SetActive(true);
                break;

            case "What city is known as a concrete jungle?":

                QuestionClearer();
                questions[5].SetActive(true);
                break;

            case "What blockly game has had a movie released about it recently?":

                QuestionClearer();
                questions[6].SetActive(true); break;

            case "What game has arguably made a foundation for competitive speedrunning":

                QuestionClearer();
                questions[7].SetActive(true); break;

            case "What game was rocket leagues' prequel?":

                QuestionClearer();
                questions[8].SetActive(true); break;

            case "When was the origianl Doom released?":

                QuestionClearer();
                questions[9].SetActive(true); break;

            case "What is the horror game about spending 5 nights somewhere":

                QuestionClearer();
                questions[10].SetActive(true); break;

            case "What is a popular toilet reffered to in brain rot videos":

                QuestionClearer();
                questions[11].SetActive(true); break;

            case "What popular game company made the souls-like genre":

                QuestionClearer();
                questions[12].SetActive(true); break;

            case "What fast food restaurant is known for their Big Mac?":

                QuestionClearer();
                questions[13].SetActive(true); break;

            case "What was the 4th game a week theme?":

                QuestionClearer();
                questions[14].SetActive(true); break;

            case "When has the original Atari came out?":

                QuestionClearer();
                questions[15].SetActive(true); break;

            case "What was the Call of Duty series inspired by?":

                QuestionClearer();
                questions[16].SetActive(true); break;

            case "What is the smallest country in the world?":

                QuestionClearer();
                questions[17].SetActive(true); break;

            case "What is the name of the official speedrunning website?":

                QuestionClearer();
                questions[18].SetActive(true); break;

            case "Which minecraft server is arguarbly the most popular?":

                QuestionClearer();
                questions[19].SetActive(true); break;

            case "Which main character was played the most in Resident Evil?":

                QuestionClearer();
                questions[20].SetActive(true); break;

            case "Who is the Kratos' son in the God of War series?":

                QuestionClearer();
                questions[21].SetActive(true); break;

            case "What DC superhero wears a bat costume?":

                QuestionClearer();
                questions[22].SetActive(true); break;

            case "What was the recent movie that flopped for Disney?":

                QuestionClearer();
                questions[23].SetActive(true); break;

            case "What is the hit football game series called?":

                QuestionClearer();
                questions[24].SetActive(true); break;
        }
    }
}
