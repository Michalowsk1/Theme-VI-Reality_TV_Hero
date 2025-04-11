using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderHandle : MonoBehaviour
{

    bool connecting;
    bool notConnecting;
    // Start is called before the first frame update
    void Start()
    {
        connecting = false;
        notConnecting = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

    }
}
