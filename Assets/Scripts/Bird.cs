using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bird : MonoBehaviour
{
    public GameManager gameManager;

    public float velocity;
    public float tiltSmooth;
    public Rigidbody2D rb;
    public GameObject startPanel;
    public AudioSource audioSource;

    public Animator animator;

    public AudioClip die;
    public AudioClip hit;

    Quaternion downRotation;
    Quaternion forwardRotation;

    // Start is called before the first frame update
    void Start()
    {
        downRotation = Quaternion.Euler(0, 0, -90);
        forwardRotation = Quaternion.Euler(0, 0, 35);

        animator.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(startPanel.activeSelf == false && Time.timeScale == 1 && !GameManager.isGameover)
        {
            Fly();  // ação de voar do pássaro
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!GameManager.isGameover)
        {
            GameManager.isGameover = true;
            animator.enabled = false;

            StartCoroutine("Gameover");
        }
    }

    public void Fly()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Jump
            transform.rotation = forwardRotation;
            rb.velocity = Vector2.up * velocity;
            audioSource.Play();

            //rb.AddForce(new Vector2(0, 50), ForceMode2D.Force);

        }

        transform.rotation = Quaternion.Lerp(transform.rotation, downRotation, tiltSmooth * Time.deltaTime);
    }

    private IEnumerator Gameover()
    {
        audioSource.clip = hit;
        audioSource.Play();

        //Espera
        yield return new WaitForSeconds(0.5f);

        audioSource.clip = die;
        audioSource.Play();

        //Espera
        yield return new WaitForSeconds(0.5f);

        gameManager.Gameover();

    }
}
