using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stop_Screen : MonoBehaviour
{
    public Score score_curent;
    public Text score;

    private void Update()
    {
        score.text = "Score: " + score_curent.score;
    }
}
