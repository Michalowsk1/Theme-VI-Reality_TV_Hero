using UnityEngine;

public class Buttons : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject TriviaGame;
    [SerializeField] GameObject DanceGame;
    [SerializeField] GameObject SingingGame;
    [SerializeField] GameObject FinalGame;


    void Start()
    {
        mainMenu.SetActive(true);
        TriviaGame.SetActive(false);
        DanceGame.SetActive(false);
        SingingGame.SetActive(false);
        FinalGame.SetActive(false);
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
        Singing.timeLeftInt = 60;
        mainMenu.SetActive(false);
        SingingGame.SetActive(true);
    }

    public void playFinalLvl()
    {
        if (HUD.fameLvl >= 3)
        {
            mainMenu.SetActive(false);
            FinalGame.SetActive(true);
        }
        else { }
    }

    public void PlayAgain()
    {
        FinalGame.SetActive(false);
        FinalGame.SetActive(true);
        FinalLvl.points = 0;
        FinalLvl.maxPoints = 15;
    }

}
