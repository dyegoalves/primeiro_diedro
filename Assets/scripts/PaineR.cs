using System;
using UnityEngine;
using UnityEngine.UI;

public class PaineR : MonoBehaviour
{
    public Color color = Color.white;
    public bool clikR = false;
    public String nameR;
    public GameObject VistaFrente;
    public GameObject VistaLateral;
    public GameObject VistaSuperior;

    public void chamaImagemSelecionada(GameObject painelimgR)
    {
        // Atribui imagem ao GameObject selecionado   
        if (painelimgR.name == nameR && clikR == false)
        {
            clikR = true;
            color.a = 1;
            painelimgR.GetComponent<RawImage>().color = color;

            if (painelimgR.name == "painelR1")
            {
                VistaFrente.GetComponent<SpriteRenderer>().color = color;
            }
            if (painelimgR.name == "painelR2")
            {
                VistaLateral.GetComponent<SpriteRenderer>().color = color;
            }

            if (painelimgR.name == "painelR3")
            {
                VistaSuperior.GetComponent<SpriteRenderer>().color = color;
            }
        }
        else
        {
            clikR = false;
            color.a = 0;
            painelimgR.GetComponent<RawImage>().color = color;

            if (painelimgR.name == "painelR1")
            {
                VistaFrente.GetComponent<SpriteRenderer>().color = color;
            }

            if (painelimgR.name == "painelR2")
            {
                VistaLateral.GetComponent<SpriteRenderer>().color = color;

            }

            if (painelimgR.name == "painelR3")
            {
                VistaSuperior.GetComponent<SpriteRenderer>().color = color;
            }
        }
    }
}
