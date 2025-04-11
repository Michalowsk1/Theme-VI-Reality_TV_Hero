using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class NotesBehavior : MonoBehaviour
{
    [SerializeField] Rigidbody2D note;

    public static int score;


    void Start()
    {
        note = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        note.velocity = new Vector2(-Singing.movespeed, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Destroy(gameObject);
            score = score - 10;
        }

        if(collision.gameObject.tag == "Player")
        {
            score = score + 10;
            Destroy(gameObject);
        }
    }
}

