using UnityEngine;

public class Buttons : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject TriviaGame;
    [SerializeField] GameObject Dance;
    [SerializeField] GameObject Singing;


    void Start()
    {
        mainMenu.SetActive(true);
        TriviaGame.SetActive(false);
        Dance.SetActive(false);
        Singing.SetActive(false);
    }

    public void playTrivia()
    {
        Trivia.timeLeftInt = 20;
        mainMenu.SetActive(false);
        TriviaGame.SetActive(true);
    }

    public void playDance()
    {
        mainMenu.SetActive(false);
        Dance.SetActive(true);
    }

    public void playSing()
    {
        mainMenu.SetActive(false);
        Singing.SetActive(true);
    }

}
