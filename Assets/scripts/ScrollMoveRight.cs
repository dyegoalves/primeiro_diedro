using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScrollMoveRight : MonoBehaviour , IPointerClickHandler
{

    public RectTransform rectTransform;
    public Texture2D mouseCursorType;
    public GameObject buttonRL;
    public Texture imageLF; //Reference to a preset image


    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.ForceSoftware);
    }

  
    public void OnPointerClick(PointerEventData data)
    {
        rectTransform.localPosition += Vector3.right + new Vector3(20,0,0);
        buttonRL.GetComponent<RawImage>().texture = imageLF;

    }
    void OnMouseEnter()
    {
        Cursor.SetCursor(mouseCursorType, Vector2.zero, CursorMode.ForceSoftware);
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.ForceSoftware);
    }

}
