using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

// Add Rigidbody2D to the player automatically
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private float movementX;
    private float movementY;
    public float speed = 2;
    public float maxSpeed = 5;
    public float speedTotation = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void OnFire()
    {
        SoundManager.instance.PlayShoot();
    }

    private void FixedUpdate()
    {
        //rb.velocity = new Vector2(movementX, movementY) * speed;
        rb.rotation -= movementX * speedTotation;
        speed = Mathf.Clamp(speed + movementY, 1.5f, maxSpeed);
        rb.velocity = transform.up * speed;
    }
}
