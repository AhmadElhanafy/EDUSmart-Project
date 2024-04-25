using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Networking.Types;

public class Dragable : MonoBehaviour, IBeginDragHandler,IDragHandler, IEndDragHandler
{
    Transform instensesPanel;

    private void Start()
    {
        instensesPanel = GameObject.Find("Instenses").transform;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        transform.SetParent(instensesPanel);
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        var pos = transform.position;

        var nearest = BlockComponent.AllPoints.OrderBy(go => (go.transform.position - pos).sqrMagnitude).FirstOrDefault();
        if(nearest != null)
        {
            float distance = Vector3.Distance(nearest.transform.position, pos);
            Debug.Log(distance);
            if (distance < 70)
            {
                if (nearest.name == "Right")
                {
                    transform.position = nearest.transform.position;
                    transform.SetParent(nearest.transform.parent);
                }
                else if (nearest.name == "Left")
                {
                    transform.position = nearest.transform.position;
                    nearest.transform.parent.gameObject.transform.SetParent(transform);
                }
            }
            else 
            {
                transform.SetParent(instensesPanel);
            }
        }
    }
}