using UnityEngine;

public class PausePanel : MonoBehaviour
{

    public GameObject pausePanel;
    public GameObject blockPanel;

    // Start is called before the first frame update
    void Start()
    {
        pausePanel.SetActive(false);
        blockPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                blockPanel.SetActive(true);
                pausePanel.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                blockPanel.SetActive(false);
                pausePanel.SetActive(false);
            } 
        }
    }


    public void Resume()
    {
        Time.timeScale = 1;
        blockPanel.SetActive(false);
        pausePanel.SetActive(false);
    }

    public void CloseGame()
    {
        // Fecha o jogo
        Application.Quit();
    }


}
