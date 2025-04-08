
using TMPro;
using UnityEngine;

public class TriviaDictionary : MonoBehaviour
{

    [SerializeField] TextMeshPro question;

    public static bool questionAnsweredC;
    public static bool questionAnsweredI;
    // Start is called before the first frame update
    void Start()
    {
        questionAnsweredC = false;
        questionAnsweredI = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Correct()
    {
        HUD.score += 10;
        question.text = gameManager.TriviaDict[Random.Range(1, gameManager.numOfQuestions)];
        questionAnsweredC = true;
        
    }

    public void InCorrect()
    {
        HUD.score -= 5;
        question.text = gameManager.TriviaDict[Random.Range(1, gameManager.numOfQuestions)];
        questionAnsweredI = true;
    }

}


