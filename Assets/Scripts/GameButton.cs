using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameButton : MonoBehaviour
{
    [SerializeField] Button menu;
    [SerializeField] Button reset;
    [SerializeField] Score score;

    void Start()
    {
        menu.onClick.AddListener(Menu);
        reset.onClick.AddListener(Reset);
        score.score = 0;
    }

    public void Reset()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
}
