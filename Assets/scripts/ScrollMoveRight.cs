using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScrollMoveRight : MonoBehaviour , IPointerClickHandler
{

    public RectTransform rectTransform;

    public Texture2D mouseOn;
   

    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.ForceSoftware);
    }

  
    public void OnPointerClick(PointerEventData data)
    {
        rectTransform.localPosition += Vector3.right + new Vector3(20,0,0);
    }
    void OnMouseEnter()
    {
        Cursor.SetCursor(mouseOn, Vector2.zero, CursorMode.ForceSoftware);
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.ForceSoftware);
    }

}
