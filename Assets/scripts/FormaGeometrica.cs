using UnityEngine;
using UnityEngine.UI;

public class FormaGeometrica : MonoBehaviour
{
    public GameObject buttonL;
    public GameObject buttonR;
    public Texture imageLon;    //Reference to a preset image
    public Texture imageRon;    //Reference to a preset image
    public Texture imageLoff;   //Reference to a preset image
    public Texture imageRoff;   //Reference to a preset image
    Ray ray;
    RaycastHit hit;
    void Update()
    {
        //Se ray do mouse colidir com GameObject view ativa a funcao do Scroll 
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.name == "view")
            {
                if (Input.GetAxis("Mouse ScrollWheel") > 0f) // forward
                {
                    buttonR.GetComponent<RawImage>().texture = imageRon;
                }
                else if (Input.GetAxis("Mouse ScrollWheel") < 0f) // backwards
                {
                    buttonL.GetComponent<RawImage>().texture = imageLon;
                }
            }
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        //Se colidir com obj f-menu que é um dos pontos finais da lista muda imagem
        if (collision.gameObject.CompareTag("colisorL"))
        {
            buttonL.GetComponent<RawImage>().texture = imageLoff;
            buttonR.GetComponent<RawImage>().texture = imageRon;
        }
        if (collision.gameObject.CompareTag("colisorR"))
        {
            buttonR.GetComponent<RawImage>().texture = imageRoff;
            buttonL.GetComponent<RawImage>().texture = imageLon;
        }
    }
}
