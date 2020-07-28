using UnityEngine;

public class GameOverPanelSE : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject ScorePanel;

    public void Swooshing()
    {
        audioSource.Play();
    }

    public void ScorePanelActivate()
    {

        ScorePanel.SetActive(true);
       
    }
}
