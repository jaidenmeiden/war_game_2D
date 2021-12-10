using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public delegate void PlayerDeath();
    public static event PlayerDeath OnPlayerDeath;

    public GameObject gameOverScreen;

    public static Action OnUpdateScore;

    private void Awake()
    {
        gameOverScreen.SetActive(false);
        OnPlayerDeath += ShowGameOverScreen;
    }

    private void OnEnable()
    {
        OnUpdateScore += UpdateScoreUI;
    }

    private void ShowGameOverScreen()
    {
        gameOverScreen.SetActive(true);
    }

    public void PlayerKilled()
    {
        OnPlayerDeath?.Invoke();
    }

    public void UpdateScoreUI()
    {
        Debug.Log("Score Updated");
    }
}