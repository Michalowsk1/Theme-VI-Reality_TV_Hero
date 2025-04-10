using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;


public class Singing : MonoBehaviour
{
    [SerializeField] GameObject pitchLevel;

    [SerializeField] GameObject[] Notes;

    public Transform PitchSpawn;

    public static float movespeed;

    int randInt;

    int randPosInt;

    int stage;

    float noteSpawnY;

    int noteSize;

    float spawnTime;

    public float noteSpawnTime;
    // Start is called before the first frame update
    void Start()
    {
        noteSpawnY = 0;
        pitchLevel.transform.position = PitchSpawn.position;
    }

    // Update is called once per frame
    void Update()
    {
        stageChanger();
        PitchMove();
        NoteSpawn();
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
        stage = 1;
        if (stage == 1)
        {
            noteSize = 0;
            movespeed = 2f;
            spawnTime = 0.25f;
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
