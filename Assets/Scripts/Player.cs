using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Score scoreCurent;
    public bool isAlive = true;
    
    private float movement;
    
    private readonly float moveSpeed = 300;

    private void Start()
    {
        scoreCurent.score = 0;
    }

    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0;
        isAlive = false;
    }
}
