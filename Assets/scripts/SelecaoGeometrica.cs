using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SelecaoGeometrica : MonoBehaviour, IPointerClickHandler
{
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

    //Figura 3D selecionda 
    public GameObject Figura3DSlc;

    //Lista de Texturas para selecao menu;
    public List<Texture> texturesMenu = new List<Texture>();

    // Start is called before the first frame update
    void Start()
    {
        //Starta o objeto a_menu e suas respectivas figuras 
        Initial_a_menu.GetComponent<RawImage>().texture = TexObj_a_menuSLC;

        //Starta o objeto painelImgR0 e suas respectivas figuras 
        painelImgR0Incial.GetComponent<RawImage>().texture = ImgDTInicial;
    }
    // Update is called once per frame
    void Update() { }

    //Ao clickar sobre o menu de selecao, chama a funcao de mudaImgPainelViewRight;
    public void OnPointerClick(PointerEventData data)
    {
        mudaImgPainelViewRight();
    }

    //Funcao para mudar as imagens do painel e da selacao menu.
    void mudaImgPainelViewRight()
    {
        //Destroy GamesObject com a TAGs LT3D, instanciando somente o objeto clicado;
        if (GameObject.FindWithTag("LT3D") != null)
        {
            Destroy(GameObject.FindWithTag("LT3D"));
        }

        //Show Figura 3D instancia a ser criada;
        _ = Instantiate(Figura3DSlc);

        //Muda a imagem ao clicar do paineis right 
        painelImgR0.GetComponent<RawImage>().texture = ImgDesenhoTecnico;
        painelR1.GetComponent<RawImage>().texture = painelImgR1;
        painelR2.GetComponent<RawImage>().texture = painelImgR2;
        painelR3.GetComponent<RawImage>().texture = painelImgR3;

        //Muda as imagens das vistas Frente, Lateral e Superior 
        VistaFrente.GetComponent<SpriteRenderer>().sprite = VistaFrente1;
        VistaLateral.GetComponent<SpriteRenderer>().sprite = VistaLatera2;
        VistaSuperior.GetComponent<SpriteRenderer>().sprite = VistaSuperior3;

        //Se vistaFrente for o sprite i_tecnico_0 flipa X = true, para posicao correta 
        if (VistaFrente.GetComponent<SpriteRenderer>().sprite.name == "i_tecnico_0")
        {
            VistaFrente.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            VistaFrente.GetComponent<SpriteRenderer>().flipX = false;
        }

        //Cria uma lista dos objetos filhos do content
        for (int i = 0; i < content.transform.childCount; i++)
        {
            //Recupera todos o filhos do GamaeObject content
            GameObject child = content.transform.GetChild(i).gameObject;

            //Seleciona somente o objeto clicado e seta a textura de selecao no mesmo 
            if (child.name == ObjetoMenuClicado.name)
            {
                ObjetoMenuClicado.GetComponent<RawImage>().texture = TexObjMenuClicado;
            }
            else
            {
                //Muda todas imagens para o padrao nao selecionada; 
                child.GetComponent<RawImage>().texture = texturesMenu[i];
            }
        }

    }
}