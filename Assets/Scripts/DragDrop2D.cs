using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragDrop2D : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler,IPointerDownHandler
{
    private RectTransform rectTransform;
    private Image image;
    private Rigidbody2D rigidbody;
    
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        image = GetComponent<Image>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        image.color = new Color32(255,255,255,170);
        rigidbody.bodyType = RigidbodyType2D.Static;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
       image.color = new Color32(255,255,255,255);
       rigidbody.bodyType = RigidbodyType2D.Dynamic;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Object Clicked");
    }
}
