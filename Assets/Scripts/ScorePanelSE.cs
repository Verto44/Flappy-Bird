using UnityEngine;

public class ScorePanelSE : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject ScoreText;

    public void Swooshing()
    {
        audioSource.Play();
    }

    public void ScoreTextActivate()
    {
        ScoreText.SetActive(true);
    }
}
