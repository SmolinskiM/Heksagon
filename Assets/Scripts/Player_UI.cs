using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_UI : MonoBehaviour
{
    public Canvas stop_screen;
    public Text text;
    public Score score_curent;
    public Player player;
    bool stop_game = false;

    private void Start()
    {
        player = GetComponent<Player>();
        Time.timeScale = 1;
    }

    private void Update()
    {
        text.text = "Score : " + score_curent.score;

        if(Input.GetKeyDown(KeyCode.Escape) && player.is_alive)
        {
            if(!stop_game)
            {
                Time.timeScale = 0;
                stop_game = true;
                stop_screen.gameObject.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                stop_game = false;
            }
            stop_screen.gameObject.SetActive(stop_game);
        }
    }

    public void Reset()
    {
        Time.timeScale = 1;
        score_curent.score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void End()
    {
        score_curent.score = 0;
        SceneManager.LoadScene("Menu");
    }
}
