using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyMove : MonoBehaviour
{
    public Transform target;
    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Director vector = final vector - initial vector
        // Unit vector = Director vector / [Director vector] 
        // Note: Divided by magnitude
        
        // Quick chase. The greater the distance between the objects, the faster the velocity
        //rb.velocity = target.position - transform.position; 
        // Constant velocity. Regardless of the distance, the chase is at the same speed.
        rb.velocity = (target.position - transform.position).normalized; 
    }
}
