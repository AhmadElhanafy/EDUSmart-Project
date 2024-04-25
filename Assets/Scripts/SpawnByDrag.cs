using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class SpawnByDrag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    GameObject newDragableObject;
    public void OnBeginDrag(PointerEventData eventData)
    {
        newDragableObject =  Instantiate(Resources.Load("dragable"), GameObject.Find("Instenses").transform) as GameObject;
    }

    public void OnDrag(PointerEventData eventData)
    {
        newDragableObject.transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        newDragableObject.transform.position = Input.mousePosition;
    }
}
 