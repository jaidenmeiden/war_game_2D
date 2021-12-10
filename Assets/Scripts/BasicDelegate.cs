using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicDelegate : MonoBehaviour
{
    delegate void SimpleMessage();
    private SimpleMessage simpleMessage;
    
    // Start is called before the first frame update
    void Start()
    {
        simpleMessage += SendConsoleMessage;
        simpleMessage += SendSecondConsoleMessage;
        simpleMessage.Invoke();
    }

    private void SendConsoleMessage()
    {
        Debug.Log("Message sent to console");
    }

    private void SendSecondConsoleMessage()
    {
        Debug.Log("Second message sent to console");
    }
}