using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    float spawn_rate = 0.5f;
    public GameObject hexagon;

    float spawn_next = 0;

    void Update()
    {
        if(Time.time >= spawn_next)
        {
            Instantiate(hexagon, Vector3.zero, Quaternion.identity);
            spawn_next = Time.time + 1 / spawn_rate;
        }
    }
}
