using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SelecaoGeometrica : MonoBehaviour , IPointerClickHandler
{
    public GameObject content;
    public GameObject ObjetoMenuClicado;
    public GameObject painelImgR1;
    public GameObject painelImgR2;
    public GameObject painelImgR3;

    public Texture TexObjMenuClicado;
    public Texture TexImgR1;
    public Texture TexImgR2;
    public Texture TexImgR3;
    public List<Texture> texturesMenu = new List<Texture>();

    public GameObject Initial_a_menu;
    public Texture TexObj_a_menuSLC;



    // Start is called before the first frame update
    void Start()
    {

        Initial_a_menu.GetComponent<RawImage>().texture = TexObj_a_menuSLC;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerClick(PointerEventData data)
    {
       mudaImgPainelViewRight();
    }

    void mudaImgPainelViewRight()

    {
        painelImgR1.GetComponent<RawImage>().texture = TexImgR1;
        painelImgR2.GetComponent<RawImage>().texture = TexImgR2;
        painelImgR3.GetComponent<RawImage>().texture = TexImgR3;

        //Todos os objetos 
        for (int i = 0; i < content.transform.childCount; i++)
        {
            GameObject child = content.transform.GetChild(i).gameObject;
                        
            //Do something with child
            if (child.name == ObjetoMenuClicado.name) {
                ObjetoMenuClicado.GetComponent<RawImage>().texture = TexObjMenuClicado;
            }
            else
            {
                child.GetComponent<RawImage>().texture = texturesMenu[i];
            }            
        }
    }
}

