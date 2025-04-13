using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lootrop : MonoBehaviour
{
    [SerializeField] GameObject smoke;

    GameObject smokeClone;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Cursor")
        {
            if (cursorScript.slash)
            {
                Destroy(gameObject);
                smokeClone = Instantiate(smoke, gameObject.transform.position, Quaternion.identity);
                Destroy(smokeClone, 1);
            }
        }
    }
}
