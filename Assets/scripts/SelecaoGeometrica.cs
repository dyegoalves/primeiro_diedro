using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SelecaoGeometrica : MonoBehaviour , IPointerClickHandler{
    //GameObject Conteudo do menu
    public GameObject content;

    //GameObject menu clicado 
    public GameObject ObjetoMenuClicado;
    public Texture TexObjMenuClicado;
    
    //GameObject Painel right Imagem R0
    public GameObject painelImgR0;
    public Texture ImgDesenhoTecnico;

    //GameObject e Textura Initial a_menu
    public GameObject Initial_a_menu;
    public Texture TexObj_a_menuSLC;

    //GameObject e Textura Initial painelR0
    public GameObject painelImgR0Incial;
    public Texture ImgDTInicial;
    
    //Lista de Texturas para selecao menu;
    public List<Texture> texturesMenu = new List<Texture>();
    
    // Start is called before the first frame update
    void Start(){
        //Starta o objeto a_menu e suas respectivas figuras 
        Initial_a_menu.GetComponent<RawImage>().texture = TexObj_a_menuSLC;

        //Starta o objeto painelImgR0 e suas respectivas figuras 
        painelImgR0Incial.GetComponent<RawImage>().texture = ImgDTInicial;
    }
    // Update is called once per frame
    void Update(){}

    public void OnPointerClick(PointerEventData data){
       mudaImgPainelViewRight();
    }

    //Funcao para mudar as imagens do painel e da selacao menu.
    void mudaImgPainelViewRight() {
       
        //Muda a imagem ao clicar 
        painelImgR0.GetComponent<RawImage>().texture = ImgDesenhoTecnico;
       
       //Muda todas imagens para o padrao nao selecionada; 
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
