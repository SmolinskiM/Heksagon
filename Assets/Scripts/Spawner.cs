using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    float spawn_rate = 0.5f;
    public GameObject hexagon;

    //public Material material;
    //Color[] color = { Color.red, Color.yellow, Color.green, Color.magenta, Color.cyan};
    float spawn_next = 0;

    void Update()
    {
        if(Time.time >= spawn_next)
        {
            //material.SetColor("_EmissionColor", color[Random.Range(0, color.Length - 1)]);
            Instantiate(hexagon, Vector3.zero, Quaternion.identity);
            spawn_next = Time.time + 1 / spawn_rate;
        }
    }
}
