using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScrollMoveRight : MonoBehaviour, IPointerClickHandler
{
    public RectTransform rectTransform;
    public GameObject buttonLR;
    public Texture imageLR; //Reference to a preset image

    // Start is called before the first frame update
    void Start() { }

    public void OnPointerClick(PointerEventData data)
    {
        rectTransform.localPosition += Vector3.right + new Vector3(20, 0, 0);
        buttonLR.GetComponent<RawImage>().texture = imageLR;

    }

}
