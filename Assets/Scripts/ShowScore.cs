using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    [SerializeField] private Text score;
    [SerializeField] private Score scoreCurent;

    void Update()
    {
        score.text = "Score: " + scoreCurent.score;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameObject.SetActive(!isActiveAndEnabled);
        }
    }
}
