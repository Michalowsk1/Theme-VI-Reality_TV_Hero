using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lootrop : MonoBehaviour
{
    [SerializeField] GameObject[] audience;

    int randSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        randSpawn = Random.Range(0, 3);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Cursor")
        {
            if (cursorScript.slash)
            {
                Destroy(gameObject);
                Instantiate(audience[randSpawn], gameObject.transform.position, Quaternion.identity);
            }
        }
    }
}
