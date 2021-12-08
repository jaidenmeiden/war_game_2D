using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Init application");
        //Debug.LogWarning("Warning. She is too close!");
        //Debug.LogError("Error. No money!");

        for (int i = 0; i < 10; i++)
        {
            Debug.LogFormat($"<color=blue>{i}</color>");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
