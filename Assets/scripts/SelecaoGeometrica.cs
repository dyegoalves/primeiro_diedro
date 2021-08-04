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
        
    //GameObject e Textura Initial a_menu
    public GameObject Initial_a_menu;
    public Texture TexObj_a_menuSLC;

    //GameObject e Textura Initial painelR0
    public GameObject painelImgR0Incial;
    public Texture ImgDTInicial;

    //GameObject Painel right Imagem R0
    public GameObject painelImgR0;
    public Texture ImgDesenhoTecnico;
    public GameObject painelR1;
    public GameObject painelR2;
    public GameObject painelR3;
    public Texture painelImgR1;
    public Texture painelImgR2; 
    public Texture painelImgR3;

    //Objetos Vistas
    public GameObject VistaFrente;
    public GameObject VistaLateral;
    public GameObject VistaSuperior;
    public Sprite VistaFrente1;
    public Sprite VistaLatera2;
    public Sprite VistaSuperior3;

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

        //Muda a imagem ao clicar do paineis right 
        painelImgR0.GetComponent<RawImage>().texture    = ImgDesenhoTecnico;
        painelR1.GetComponent<RawImage>().texture       = painelImgR1;
        painelR2.GetComponent<RawImage>().texture       = painelImgR2;
        painelR3.GetComponent<RawImage>().texture       = painelImgR3;
       
        //Muda as imagens das vistas Frente, Lateral e Superior 
        VistaFrente.GetComponent<SpriteRenderer>().sprite   = VistaFrente1;
        VistaLateral.GetComponent<SpriteRenderer>().sprite  = VistaLatera2;
        VistaSuperior.GetComponent<SpriteRenderer>().sprite = VistaSuperior3;

        //Se vistaFrente for o sprite i_tecnico_0 flipa o Sprite para posicao correta 
        if( VistaFrente.GetComponent<SpriteRenderer>().sprite.name == "i_tecnico_0"){
            VistaFrente.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            VistaFrente.GetComponent<SpriteRenderer>().flipX = false;
        }

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