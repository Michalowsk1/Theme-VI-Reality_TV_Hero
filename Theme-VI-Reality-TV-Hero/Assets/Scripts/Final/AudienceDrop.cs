using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AudienceDrop : MonoBehaviour
{
    [SerializeField] GameObject[] audience;
    int randomInt;
    float timeSinceDestroy;


    void Start()
    {
        timeSinceDestroy = 0;
    }

    // Update is called once per frame
    void Update()
    {
        randomInt = Random.Range(0, 3);
        timeSinceDestroy += Time.deltaTime;

        if (timeSinceDestroy >= 1)
        {
            Instantiate(audience[randomInt], gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
