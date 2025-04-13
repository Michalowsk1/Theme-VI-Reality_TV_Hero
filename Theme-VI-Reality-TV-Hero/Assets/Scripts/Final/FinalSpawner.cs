using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalSpawner : MonoBehaviour
{
    [SerializeField] GameObject box;

    public Transform[] boxSpawner;

    float floatTimer;

    int randSpawnInt;
    int randBoxInt;



    void Start()
    {
        floatTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (FinalLvl.game)
        {
            floatTimer += Time.deltaTime;

            randSpawnInt = Random.Range(0, 3);
            randBoxInt = Random.Range(0, 3);

            if(floatTimer >= 2)
            {
                Instantiate(box, boxSpawner[randSpawnInt].position, Quaternion.identity);
                floatTimer = 0;
            }
        }
    }
}
