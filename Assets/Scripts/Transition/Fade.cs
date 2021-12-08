using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Fade : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer spriteRenderer;

    private void Start()
    {
        FadeOut();
    }
    
    [ContextMenu("FadeIn")]
    public void FadeIn()
    {
        spriteRenderer.DOFade(1,2).OnComplete(() =>
        {
            Debug.Log("FadeIn finished!");
        });
    }
    
    [ContextMenu("FadeOut")]
    public void FadeOut()
    {
        spriteRenderer.DOFade(0,2).OnComplete(StartGame).OnStart(() =>
        {
            Debug.Log("FadeOut started!");
        });
    }

    private static void StartGame()
    {
        Debug.Log("FadeOut finished!");
    }
}
