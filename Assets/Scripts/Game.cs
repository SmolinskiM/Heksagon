using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public int score = 0;
    public Text score_text;

    void Start()
    {
        score = 0;
    }

    void Update()
    {
        score_text.text = "Score: " + score;
    }
}
