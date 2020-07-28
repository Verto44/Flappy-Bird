using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject pipe;
    public float height;


    // Start is called before the first frame update
    void Start()
    {
        GameObject newPipe = Instantiate(pipe, transform.position, transform.rotation);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(timer > maxTime)
        {
            GameObject newPipe = Instantiate(pipe, transform.position, transform.rotation);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
