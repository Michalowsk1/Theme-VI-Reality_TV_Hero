using UnityEngine;

public class Buttons : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject TriviaGame;
    [SerializeField] GameObject DanceGame;
    [SerializeField] GameObject SingingGame;


    void Start()
    {
        mainMenu.SetActive(true);
        TriviaGame.SetActive(false);
        DanceGame.SetActive(false);
        SingingGame.SetActive(false);
    }

    public void playTrivia()
    {
        Trivia.timeLeftInt = 20;
        mainMenu.SetActive(false);
        TriviaGame.SetActive(true);
    }

    public void playDance()
    {
        Dance.timeLeftInt = 30;
        mainMenu.SetActive(false);
        DanceGame.SetActive(true);
    }

    public void playSing()
    {
        mainMenu.SetActive(false);
        SingingGame.SetActive(true);
    }

}
