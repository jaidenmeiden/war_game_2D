using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    //public GameObject explosionEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            FindObjectOfType<GameManager>().PlayerKilled();
            
            /*GameObject go = Instantiate(explosionEffect);
            go.transform.position = transform.position;
            Destroy(gameObject);*/
        }
    }
}
