using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Score score_curent;
    float move_speed = 300;
    float movement;
    public Canvas dead_screen;
    public bool is_alive = true;

    private void Start()
    {
        score_curent.score = 0;
    }

    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -move_speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0;
        is_alive = false;
        dead_screen.gameObject.SetActive(true);
    }
}
