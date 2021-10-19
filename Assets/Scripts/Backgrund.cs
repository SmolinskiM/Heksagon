using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgrund : MonoBehaviour
{
    public Color[] colors;
    int curent_index;
    Camera camera;

    void Start()
    {
        camera = GetComponent<Camera>();

        SetColor(colors[curent_index]);
    }

    public void SetColor(Color color)
    {
        camera.backgroundColor = color;
    }

    public void Cycle_color()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
