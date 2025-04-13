using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorePoints : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Cursor")
        {
            if(cursorScript.slash)
            {
                Destroy(gameObject);
            }

            else if(cursorScript.click)
            {
                Destroy(gameObject);
                FinalLvl.points++;
            }
        }
    }
}
