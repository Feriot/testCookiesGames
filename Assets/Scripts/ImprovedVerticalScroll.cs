using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ImprovedVerticalScroll : ScrollRect
{
    /*public override void OnBeginDrag(PointerEventData eventData)
    {
        base.OnBeginDrag(eventData);
        Debug.Log("VERTICAL scroll OnBeginDrag");
    }


    public override void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("VERTICAL scroll OnEndDrag");
        Transform horizontalScrollsContainer = this.transform.GetChild(0);
        base.OnEndDrag(eventData);
        foreach (Transform child in horizontalScrollsContainer)
        {
            child.GetComponent<ImprovedHorizontalScroll>().enabled = true;
        }
    }*/
}
