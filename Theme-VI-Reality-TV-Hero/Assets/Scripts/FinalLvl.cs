using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalLvl : MonoBehaviour
{
    [SerializeField] GameObject timeline;
    [SerializeField] GameObject background;

    bool game;
    // Start is called before the first frame update
    void Start()
    {
        timeline.SetActive(true);
        background.SetActive(false);
        game = false;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(IntroScene());

        if(game)
        {
            background.SetActive(true);
        }
    }

    IEnumerator IntroScene()
    {
        yield return new WaitForSeconds(28);
        game = true;
    }


}
