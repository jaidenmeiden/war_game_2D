using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ShipMovementt : MonoBehaviour
{
    public int destination;
    public int duration;
    public Ease ease;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.DOMoveX(destination, duration).SetEase(ease);
    }
}
