using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject startPanel;
    public GameObject scorePanelPlaying;
    public GameObject scorePanelGameover;
    public GameObject pipeSpawner;
    public GameObject secretPanel;
    public GameObject secretButton;

    public static bool isGameover;

    public Text txtScore;

    private void Awake()
    {
        scorePanelGameover.SetActive(false);
        startPanel.SetActive(true);
        gameOverCanvas.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        isGameover = false;
    }

    public void Gameover()
    {
        txtScore.text = Score.score.ToString();
        gameOverCanvas.SetActive(true);
        scorePanelPlaying.SetActive(false);
        pipeSpawner.SetActive(false);
    }

    public void Retry()
    {
        SceneManager.LoadScene(0);
    }

    public void PausedButton()
    {
        if(Time.timeScale == 1)       
            Time.timeScale = 0;
        else     
            Time.timeScale = 1;        
    }
}
