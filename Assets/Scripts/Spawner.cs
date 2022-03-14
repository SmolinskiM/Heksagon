using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject hexagon;

    private float spawnNext = 0;
    private readonly float spawnRate = 0.5f;

    void Update()
    {
        if(Time.time >= spawnNext)
        {
            Instantiate(hexagon, Vector3.zero, Quaternion.identity);
            spawnNext = Time.time + 1 / spawnRate;
        }
    }
}
