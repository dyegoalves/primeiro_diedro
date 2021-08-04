using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FormaGeometrica : MonoBehaviour{
    public GameObject buttonLR;
    public Texture imageLF; //Reference to a preset image

    // Start is called before the first frame update
    void Start(){}
    
    // Update is called once per frame
    void Update(){}

    void OnTriggerEnter2D(Collider2D collision){
        //Se colidir com obj f-menu que é um dos pontos finais da lista muda imagem
        if (collision.gameObject.CompareTag("colisor")) {
            buttonLR.GetComponent<RawImage>().texture = imageLF;
        }
        else{
            Debug.Log("bb");
        }
    }
}
