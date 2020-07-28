using UnityEngine;

public class StartGame : MonoBehaviour
{

    public GameObject pipeSpawner;
    public GameObject scorePanel;
    public Rigidbody2D rb;

    private void Awake()
    {
        pipeSpawner.SetActive(false);
        scorePanel.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        rb.gravityScale = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && Time.timeScale == 1)
        {
            pipeSpawner.SetActive(true);
            scorePanel.SetActive(true);
            rb.gravityScale = 1.5f; 
            gameObject.SetActive(false);
        }
    }
}
