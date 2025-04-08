using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
