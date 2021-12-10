using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public delegate void PlayerDeath();
    public static event PlayerDeath OnPlayerDeath;

    public GameObject gameOverScreen;
    
    delegate void SimpleMessage();
    private SimpleMessage simpleMessage;
    
    private void Awake()
    {
        gameOverScreen.SetActive(false);
        OnPlayerDeath += ShowGameOverScreen;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        simpleMessage += SendConsoleMessage;
        simpleMessage += SendSecondConsoleMessage;
        simpleMessage.Invoke();
    }
    
    private void ShowGameOverScreen()
    {
        gameOverScreen.SetActive(true);
    }

    public void PlayerKilled()
    {
        OnPlayerDeath?.Invoke();
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
