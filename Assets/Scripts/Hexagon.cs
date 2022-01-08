using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{
    Rigidbody2D rb;
    public Score score_curent;
    float shrink_speed = 3f;
    public Material material;
    Color[] color = { Color.red, Color.yellow, Color.green, Color.blue, Color.magenta, Color.cyan};

    void Start()
    {
        material = GetComponent<Renderer>().material;
        material.SetColor("_EmissionColor", color[Random.Range(0, color.Length)]);
        rb = GetComponent<Rigidbody2D>();
        rb.rotation = Random.Range(0, 360);
        transform.localScale = Vector3.one * 9;
    }

    void Update()
    {
        transform.localScale -= Vector3.one * shrink_speed * Time.deltaTime;

        if(score_curent.score >= 10)
        {
            rb.rotation += Time.deltaTime * 50;
        }

        if(score_curent.score >= 20)
        {
            Camera.main.transform.Rotate(Vector3.forward, Time.deltaTime * 20);
        }

        if(transform.localScale.x <= 0.5)
        {
            score_curent.score++;
            Destroy(gameObject);
        }
    }
}
