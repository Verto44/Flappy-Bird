using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScoreEnd : MonoBehaviour
{
    public Text txtScore;
    public Text txtHightScore;

    public GameObject playButton;
    public GameObject newHightScore;

    private int score;
    private int hightScore;

    public float delayWriter;

    private void Awake()
    {
        playButton.SetActive(false);
        newHightScore.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        score = Score.score;
        hightScore = PlayerPrefs.GetInt("hightScore");

        txtHightScore.text = PlayerPrefs.GetInt("hightScore").ToString();
        StartCoroutine(ShowScore(score));
    }

    IEnumerator ShowScore(int _score)
    {
        txtScore.text = "";

        for (int x = 0; x <= _score; x++)
        {

            //Técnica 01
            txtScore.text = x.ToString();

            yield return new WaitForSeconds(delayWriter);
        }

        if(score > hightScore)
        {
            newHightScore.SetActive(true);

            hightScore = score;
            PlayerPrefs.SetInt("hightScore", hightScore);
            txtHightScore.text = PlayerPrefs.GetInt("hightScore").ToString();
        }

        playButton.SetActive(true);

    }
}
