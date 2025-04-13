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

    float clickTime;

    void Start()
    {
        clickTime = 0;
        slash = false;
        click = false;
    }
    void Update()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.Lerp(transform.position, cursorPos, 1f);

        clickingSystem();

    }

    void clickingSystem()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            clickTime += Time.deltaTime;
        }
        else
        {
            clickTime = 0;
            click = false;
            slash = false;
        }

        if(clickTime < 0.5f && clickTime > 0.0f)
        {
            click = true;
            slash = false;
        }

        else if (clickTime >= 0.5f)
        {
            click = false;
            slash = true;
        }
    }
}

