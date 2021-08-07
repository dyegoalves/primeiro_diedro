using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScrollMoveLeft : MonoBehaviour, IPointerClickHandler
{
    public RectTransform rectTransform;
    public GameObject buttonRL;
    public Texture imageLF;

    // Start is called before the first frame update
    void Start() { }

    public void OnPointerClick(PointerEventData data)
    {
        rectTransform.localPosition -= Vector3.left + new Vector3(40, 0, 0);
        buttonRL.GetComponent<RawImage>().texture = imageLF;
    }
}
