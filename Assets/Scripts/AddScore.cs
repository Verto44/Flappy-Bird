using UnityEngine;
public class AddScore : MonoBehaviour
{
    public AudioSource point;   // audio tocado quando o pássaro atravessa um cano

    private void OnTriggerExit2D(Collider2D collision)
    {
        // se não estiver pausado (gameover)
        if (!GameManager.isGameover)
        {
            Score.score++; // adiciona um ponto
            point.Play();  // toca o audio da pontuação
        }
           
    }
}
