using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class WeatherChange : MonoBehaviour
{
    private string city_name = "valencia";
    private string state_code = "46017";
    private string API_key = "1d3a078f7d1473c54a01a04645f9e6d0";
    
    IEnumerator GetWeather()
    {
        UnityWebRequest www = UnityWebRequest.Get($"api.openweathermap.org/data/2.5/weather?q={city_name},{state_code}&appid={API_key}");
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError(www.error);
        }
        else
        {
            Debug.Log(www.downloadHandler.text);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetWeather());
    }
}
