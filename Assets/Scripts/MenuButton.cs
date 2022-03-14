using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuButton : MonoBehaviour
{
    [SerializeField] Button play;
    [SerializeField] Button quit;
    [SerializeField] Score score;

    private void Start()
    {
        play.onClick.AddListener(Play);
        quit.onClick.AddListener(Quit);
        score.score = 0;
    }

    void Play()
    {
        SceneManager.LoadScene("Game");
    }

    void Quit()
    {
        Application.Quit();
    }
}
