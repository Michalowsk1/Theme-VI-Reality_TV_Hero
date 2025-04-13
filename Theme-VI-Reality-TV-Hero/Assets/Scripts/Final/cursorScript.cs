using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cursorScript : MonoBehaviour
{
    [SerializeField] GameObject beers;

    [SerializeField] GameObject trail;

    public static bool slash;

    public static bool click;

    float slashTime;

    [SerializeField] Collider2D collision;

    void Start()
    {
        slashTime = 0;
        slash = false;
        click = false;
        collision.enabled = false;
    }
    void Update()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.Lerp(transform.position, cursorPos, 1f);

        clickingSystem();

    }

    void clickingSystem()
    {

        if(Input.GetKey(KeyCode.Mouse0))
        {
            slashTime += Time.deltaTime;

            if (slashTime >= 0.25f)
            {
                slash = true;
                click = false;
                collision.enabled = true;
            }
        }

        else if(Input.GetKey(KeyCode.Mouse1))
        {
            slash = false;
            click = true;
            collision.enabled = true;
        }
        else
        {
            click = false;
            slash = false;
            collision.enabled = false;
            slashTime = 0;
        }

        Debug.Log(slash + " " + click + "   " + slashTime);
    }
}

