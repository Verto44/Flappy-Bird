using UnityEngine;


//[RequireComponent(typeof(Renderer))]
public class MoveOffset : MonoBehaviour
{

    [Header("Velocidade do backgound scroll")]
    [Tooltip("Controla a velocidade do scroll")]
    [Space(8)]
    public float vel = 0.1f;    //Velocidade de deslocamento

    public Renderer quad;       //Objeto 3D do tipo Quad
    //public RawImage rImg;     //Imagem do scroll

    // Start is called before the first frame update
    void Start()
    {
        if(quad == null)
        {
            quad = gameObject.GetComponent<MeshRenderer>();
        }

        //Rect startRect = new Rect(rImg.uvRect);
        //startRect.x = 0.0f;
        //rImg.uvRect = startRect;

    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.isGameover)
        {
            Vector2 offset = new Vector2(vel * Time.deltaTime, 0);
            quad.material.mainTextureOffset += offset;
        }
       
        //if (!GameManager.paused)
        //{
        //    Rect tempRect = new Rect(rImg.uvRect);
        //    tempRect.x += vel * Time.deltaTime;
        //    rImg.uvRect = tempRect;
        //}
    }
}
