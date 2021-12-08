using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionaries : MonoBehaviour
{
    public Dictionary<string, string> dict = new Dictionary<string, string>();
    public Dictionary<string, PlayerData> playerData = new Dictionary<string, PlayerData>();

    private void Start()
    {
        dict["airplane"] = "Combat airplane";
        dict["ship"] = "Combat ship";
        dict["sea"] = "Water body";

        dict.TryGetValue("airplane", out string value);
        Debug.Log(value);

        foreach (string def in dict.Values)
        {
            Debug.Log(def);
        }

        playerData["player1"] = new PlayerData("Jaiden", 200);
        playerData["player2"] = new PlayerData("Joaquin", 100);

        foreach (PlayerData player in playerData.Values)
        {
            Debug.Log(player.name + ": " + player.score);
        }
    }
}

public class PlayerData
{
    public string name;
    public int score;

    public PlayerData(string name, int score)
    {
        this.name = name;
        this.score = score;
    }
}