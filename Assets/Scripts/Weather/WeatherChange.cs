using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using LitJson;

public class WeatherChange : MonoBehaviour
{
    private string city_name = "valencia";
    private string state_code = "46017";
    private string API_key = "1d3a078f7d1473c54a01a04645f9e6d0";
    
    private int actuaWeather;
    [SerializeField] DigitalRuby.RainMaker.RainScript2D rainmaker;

    private void WeatherChanger()
    {
        if (actuaWeather >= 200 && actuaWeather < 300)
        {
            //Storm
            rainmaker.RainIntensity = 1;
        } else if (actuaWeather >= 300 && actuaWeather < 400)
        {
            //Drizzle
            rainmaker.RainIntensity = 0.3f;
        } else if (actuaWeather >= 400 && actuaWeather < 500)
        {
            //Rain
            rainmaker.RainIntensity = 0.55f;
        } else if (actuaWeather >= 500 && actuaWeather < 600)
        {
            //Strong Rain
            rainmaker.RainIntensity = 0.7f;
        } else if (actuaWeather >= 700 && actuaWeather < 800)
        {
            //Fog
            rainmaker.RainIntensity = 0.2f;
        } else if (actuaWeather == 800)
        {
            //Clear sky
            rainmaker.gameObject.SetActive(false);
        } else if (actuaWeather > 800)
        {
            //Cloudy
            rainmaker.RainIntensity = 0.1f;
        }
    }
    
    IEnumerator GetWeather()
    {
        UnityWebRequest www = UnityWebRequest.Get($"api.openweathermap.org/data/2.5/weather?q={city_name},{state_code}&appid={API_key}");
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError(www.error);
            actuaWeather = 800;
        }
        else
        {
            //Debug.Log(www.downloadHandler.text);
            JsonData jsonData = JsonMapper.ToObject(www.downloadHandler.text);
            actuaWeather = (int) jsonData["weather"][0]["id"];
        }

        Debug.Log(actuaWeather);
        WeatherChanger();
        StopCoroutine(GetWeather());
    }
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetWeather());
    }
}
