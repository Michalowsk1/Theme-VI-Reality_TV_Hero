using System.Collections;
using System.Collections.Generic;
using System.Net;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;


public class Singing : MonoBehaviour
{
    [SerializeField] GameObject pitchLevel;

    [SerializeField] GameObject mainMenu;

    [SerializeField] GameObject singingLevel;

    [SerializeField] GameObject[] Notes;

    [SerializeField] TextMeshProUGUI scoreText;


    [SerializeField] TextMeshProUGUI timeText;

    public Transform PitchSpawn;

    public static float movespeed;

    int randInt;

    int randPosInt;

    int stage;

    float noteSpawnY;

    int noteSize;

    float spawnTime;

    public static int timeLeftInt;
    float timeLeftFloat;

    public float noteSpawnTime;

    public static bool finished;

    public static int finalScore;

    bool game;
    // Start is called before the first frame update
    void Start()
    {
        noteSpawnY = 0;
        pitchLevel.transform.position = PitchSpawn.position;
        scoreText.text = "";
        timeText.text = "";
        timeLeftInt = 60;
        stage = 1;
        finished = false;
        game = false;
    }

    // Update is called once per frame
    void Update()
    {
        stageChanger();
        lvlChanger();

        if(Input.GetKey(KeyCode.P))
        {
            game = true;
        }
        if (game)
        {
            PitchMove();
            NoteSpawn();
            TimerCountDown();
            gameOver();
        }
        randInt = Random.Range(0, 3);
        randPosInt = Random.Range(0, 2);

    }

    void PitchMove()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            pitchLevel.transform.position = new Vector2(pitchLevel.transform.position.x, pitchLevel.transform.position.y + 0.03f);
        }

        pitchLevel.transform.position = new Vector2(pitchLevel.transform.position.x, pitchLevel.transform.position.y - 0.01f);
    }

    void stageChanger()
    {
        if (stage == 1)
        {
            noteSize = 0;
            movespeed = 2f;
            spawnTime = 0.25f;
        }

        if(stage == 2)
        {
            noteSize = 0;
            movespeed = 4f;
            spawnTime = 0.125f;
        }

        if(stage == 3)
        {
            noteSize = 1;
            movespeed = 6f;
            spawnTime = 0.095f;
        }

        if(stage == 4)
        {
            noteSize = 2;
            movespeed = 8f;
            spawnTime = 0.0625f;
        }
    }

    void lvlChanger()
    {
        if(NotesBehavior.score < 750)
        {
            stage = 1;
        }

        if (NotesBehavior.score >= 750)
        {
            stage = 2;
        }

        if (NotesBehavior.score >= 1500)
        {
            stage = 3;
        }

        if (NotesBehavior.score >= 2500)
        {
            stage = 4;
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

        scoreText.text = "Score: " + NotesBehavior.score;

    }

    void gameOver()
    {
        if (timeLeftInt <= 0)
        {
            game = false;
            finished = true;
            singingLevel.SetActive(false);
            mainMenu.SetActive(true);

            finalScore = NotesBehavior.score / 10;

            HUD.finalSingingScore = finalScore;
        }
    }

    void NoteSpawn()
    {
        noteSpawnTime += Time.deltaTime;
        if (noteSpawnTime >= spawnTime)
        {
            Instantiate(Notes[noteSize], new Vector2(7, noteSpawnY), Quaternion.identity);
            noteSpawnTime = 0;

            if(randPosInt == 0)
            {
                noteSpawnY -= 0.5f;
            }

            if(noteSpawnY >= 3)
            {
                noteSpawnY -= 2f;
            }

            if(randPosInt == 1)
            {
                noteSpawnY += 0.5f;
            }

            if (noteSpawnY <= -3)
            {
                noteSpawnY += 2f;
            }
        }
    }
}
