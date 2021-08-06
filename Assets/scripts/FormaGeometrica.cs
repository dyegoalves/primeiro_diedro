using UnityEngine;
using UnityEngine.UI;

public class FormaGeometrica : MonoBehaviour
{
    public GameObject buttonLR;
    public Texture imageLR; //Reference to a preset image
    public GameObject buttonSLR;
    public Texture imageSLR; //Reference to a preset image

    void OnTriggerEnter2D(Collider2D collision)
    {
        //Se colidir com obj f-menu que é um dos pontos finais da lista muda imagem
        if (collision.gameObject.CompareTag("colisorL"))
        {
            buttonLR.GetComponent<RawImage>().texture = imageLR;
            buttonSLR.GetComponent<RawImage>().texture = imageSLR;
        }

        if (collision.gameObject.CompareTag("colisorR"))
        {
            buttonLR.GetComponent<RawImage>().texture = imageLR;
            buttonSLR.GetComponent<RawImage>().texture = imageSLR;
        }
    }
}
