using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{
    public Material material;
    public Score scoreCurent;
    
    private Rigidbody2D rb;
    private readonly float shrinkSpeed = 3f;
    private readonly Color[] color = { Color.red, Color.yellow, Color.green, Color.blue, Color.magenta, Color.cyan};
    private int rotationSpeed;

    void Start()
    {
        material = GetComponent<Renderer>().material;
        material.SetColor("_EmissionColor", color[Random.Range(0, color.Length)]);
        rb = GetComponent<Rigidbody2D>();
        rb.rotation = Random.Range(0, 360);
        transform.localScale = Vector3.one * 9;
        rotationSpeed = Random.Range(-2, 3);
    }

    void Update()
    {
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;

        if(scoreCurent.score >= 10)
        {
            rb.rotation += Time.deltaTime * 50 * rotationSpeed;
        }

        if(transform.localScale.x <= 0.5)
        {
            scoreCurent.score++;
            Destroy(gameObject);
        }
    }
}
