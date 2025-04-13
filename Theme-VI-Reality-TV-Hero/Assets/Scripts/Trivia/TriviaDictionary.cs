
using System.Collections;
using TMPro;
using Unity.Collections.LowLevel.Unsafe;
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
        if (gameManager.keyVal > 25)
        {
            gameManager.leftOverVal = gameManager.keyVal - 25;
            gameManager.keyVal = 0 + gameManager.leftOverVal;
        }
    }

    public void Correct()
    {
        HUD.score += 10;
        gameManager.keyVal += Random.Range(1, 7);
        questionAnsweredC = true;
        
    }

    public void InCorrect()
    {
        HUD.score -= 5;
        gameManager.keyVal += Random.Range(1, 7);
        questionAnsweredI = true;
    }

}


