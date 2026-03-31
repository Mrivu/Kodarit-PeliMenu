using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverSelect : MonoBehaviour, IPointerEnterHandler,
IPointerClickHandler
{
    public int index;
    public Selector selector;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Entered");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Clicked");
        selector.ActivateItem(index);
    }

    public void A()
    {
        Debug.Log("Test");
    }

}
