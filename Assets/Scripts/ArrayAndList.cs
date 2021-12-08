using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayAndList : MonoBehaviour
{
    public int[] numbers = new int[2];
    
    public int[] count;

    public List<string> names = new List<string>();
    private void Start()
    {
        foreach (int item in count)
        {
            Debug.Log(item);
        }
        
        names.Add("Jaiden");
        names.Add("Juaquin");
        names.Add("Jeronimo");
        names.Remove("Jeronimo");
        
        foreach (string item in names)
        {
            Debug.Log(item);
        }
    }
}