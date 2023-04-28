using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        Debug.LogWarning("I SAID HELLO WORLD!");
        Debug.LogError("YOU DIDN'T SAY HELLO!!!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
