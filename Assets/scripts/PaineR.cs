using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaineR : MonoBehaviour
{
    public Color color = Color.white;
    public bool clikR = false;
    public String nameR;

    public void chamaImagemSelecionada(GameObject painelimgR )
    {

        // Atribui imagem ao GameObject selecionado   
        if (painelimgR.name == nameR  && clikR == false ){
            clikR = true;
            color.a = 1;
            painelimgR.GetComponent<RawImage>().color = color;

        }
        else
        {
            clikR = false;
            color.a = 0;
            painelimgR.GetComponent<RawImage>().color = color;

        }
               
    }

}
