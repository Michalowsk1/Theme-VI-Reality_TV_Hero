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

    int stage;

    float noteSpawnY;

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
            movespeed = 2f;
        }
    }

    void NoteSpawn()
    {
        noteSpawnTime += Time.deltaTime;
        if (noteSpawnTime >= 0.25)
        {
            Instantiate(Notes[randInt], new Vector2(7, noteSpawnY), Quaternion.identity);
            noteSpawnTime = 0;
        }
    }
}
