using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScrollMoveLeft : MonoBehaviour, IPointerClickHandler
{

    public RectTransform rectTransform;
    // Start is called before the first frame update

    public Texture2D mouseOn;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.ForceSoftware);
    }


    public void OnPointerClick(PointerEventData data)
    {
          rectTransform.localPosition -= Vector3.left + new Vector3(20, 0, 0);
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
