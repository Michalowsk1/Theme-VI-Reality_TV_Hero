using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Destroy(gameObject);
        }
    }
}

