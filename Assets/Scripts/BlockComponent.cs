using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.EventSystems;

public class BlockComponent : MonoBehaviour
{
    public static readonly HashSet<BlockComponent> AllPoints = new();

    void Start()
    {
        AllPoints.Add(this);
    }

    void OnDestroy()
    {
        AllPoints.Remove(this);
    }

    public void OverrideExistence(bool state) 
    {
        if (state)
        {
            AllPoints.Add(this);
            return;
        }
        AllPoints.Remove(this);
    }
}
