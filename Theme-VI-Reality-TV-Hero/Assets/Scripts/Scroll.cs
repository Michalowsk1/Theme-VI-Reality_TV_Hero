using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    [SerializeField] Renderer background;

    // Update is called once per frame
    void Update()
    {
        background.material.mainTextureOffset += new Vector2(0.1f * Time.deltaTime, 0);
    }
}
