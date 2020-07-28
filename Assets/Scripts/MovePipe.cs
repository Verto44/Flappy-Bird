using UnityEngine;

public class MovePipe : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.isGameover)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        // destroi os canos quando eles saem da tela
        if(gameObject.transform.position.x < -5.0f)
        {
            Destroy(gameObject);
        }
        
    }
}
