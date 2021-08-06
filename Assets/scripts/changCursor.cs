using UnityEngine;

public class changCursor : MonoBehaviour
{
    public Texture2D mouseCursorType;
    // Start is called before the first frame update
    void Start()
    {
        //Cursor 
        Cursor.SetCursor(null, Vector2.zero, CursorMode.ForceSoftware);
    }

    // Update is called once per frame
    void Update() { }

    public void OnMouseEnter()
    {
        Cursor.SetCursor(mouseCursorType, Vector2.zero, CursorMode.ForceSoftware);
    }

    public void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.ForceSoftware);
    }
}
