using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject Trivia;
    [SerializeField] GameObject Dance;
    [SerializeField] GameObject Singing;


    void Start()
    {
        mainMenu.SetActive(true);
        Trivia.SetActive(false);
        Dance.SetActive(false);
        Singing.SetActive(false);
    }

    public void playTrivia()
    {
        mainMenu.SetActive(false);
        Trivia.SetActive(true);
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
