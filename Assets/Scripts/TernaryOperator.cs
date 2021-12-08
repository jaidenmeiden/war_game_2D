using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TernaryOperator : MonoBehaviour
{
    public int a;
    public int b;
    
    // Start is called before the first frame update
    void Start()
    {
        string sum = a == b ? "Es igual" : "No es igual";
        Debug.Log(sum);
    }
}
