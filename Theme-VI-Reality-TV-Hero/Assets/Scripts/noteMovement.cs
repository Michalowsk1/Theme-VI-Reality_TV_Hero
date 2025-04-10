using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesBehavior : MonoBehaviour
{
    [SerializeField] Rigidbody2D note;
    void Start()
    {
        note = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        note.velocity = new Vector2(-Singing.movespeed, 0);
    }
}

