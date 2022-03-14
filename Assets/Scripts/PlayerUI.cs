using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerUI : MonoBehaviour
{
    private bool isStopGame = false;
    
    [SerializeField] private Canvas deadScreen;
    [SerializeField] private Canvas stopScreen;
    [SerializeField] private Score scoreCurent;
    [SerializeField] private Player player;

    private void Start()
    {
        player = GetComponent<Player>();
        Time.timeScale = 1;
    }

    private void Update()
    {

        if(Input.GetKeyDown(KeyCode.Escape) && player.isAlive)
        {
            if(!isStopGame)
            {
                Time.timeScale = 0;
                isStopGame = true;
            }
            else
            {
                Time.timeScale = 1;
                isStopGame = false;
            }
            stopScreen.gameObject.SetActive(isStopGame);
        }

        if(!player.isAlive)
        {
            deadScreen.gameObject.SetActive(true);
        }
    }
}
