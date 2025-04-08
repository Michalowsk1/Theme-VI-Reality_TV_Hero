using System.Collections;
using TMPro;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Trivia : MonoBehaviour
{
    [SerializeField] GameObject level;
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject questionBox;
    [SerializeField] GameObject expBar;
    [SerializeField] TextMeshProUGUI Fame;
    [SerializeField] GameObject[] questions;
    string question;
    float xp;
    int fameLvl;
    void Start()
    {
        questionBox.SetActive(false);
        expBar.transform.localScale = new Vector2(expBar.transform.localScale.x, expBar.transform.localScale.y);
        for (int i = 0; i < questions.Length; i++)
        {
            questions[i].SetActive(false);
        }
    }

    void Update()
    {
        StartCoroutine(cutscene());
        question = TriviaDictionary.questionNum;

        QandAs();
        quitButton();
        Experience();


        
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

    void QuestionClearer()
    {
        if (TriviaDictionary.questionAnsweredC || TriviaDictionary.questionAnsweredI)
        {
            for (int i = 0; i < questions.Length; i++)
            {
                questions[i].SetActive(false);
            }
            xp = 0.1f;
            xp = 0.0f;
            TriviaDictionary.questionAnsweredC = false;
            TriviaDictionary.questionAnsweredI = false;
        }
    }

    void Experience()
    {
        expBar.transform.localScale = new Vector2(expBar.transform.localScale.x + xp, expBar.transform.localScale.y);


        //INCREASES LVL
        if (expBar.transform.localScale.x >= 0.8f)
        {
            fameLvl++;
            expBar.transform.localScale = new Vector2(0.01f, expBar.transform.localScale.y);
        }

        Fame.text = "Fame:" + fameLvl;
    }
    void QandAs()
    {
        QuestionClearer();
        switch (question)
        {
            
            case "What is the capital of England?":

                questions[0].SetActive(true);
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
