using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    public GameObject explosionEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //Instantiate(explosionEffect, transform);
            GameObject go = Instantiate(explosionEffect);
            go.transform.position = transform.position;
            Deactivate();
        }

        if (collision.CompareTag("Bullet"))
        {
            Deactivate();
            // Deactivate enemy and add this to the object pool list
        }
    }
    
    private void OnEnable()
    {
        GameManager.OnUpdateScore += Deactivate;
    }

    private void OnDisable()
    {
        GameManager.OnUpdateScore.Invoke();
        GameManager.OnUpdateScore -= Deactivate;
    }

    private void Deactivate()
    {
        // Deactivate replace Destroy
        gameObject.SetActive(false);
    }
}