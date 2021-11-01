using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Runtime.InteropServices;

public class ImprovedHorizontalScroll : ScrollRect 
{
    private bool isEnabled = true;
    private ImprovedVerticalScroll verticalScroll;

    protected override void Start()
    {
        base.Start();
        verticalScroll = this.transform.parent.parent.GetComponent<ImprovedVerticalScroll>();
    }
    public override void OnBeginDrag(PointerEventData eventData)
    {
        float x = Mathf.Abs(eventData.delta.x);
        float y = Mathf.Abs(eventData.delta.y);
        if (y > x)
        {
            isEnabled = false;
            verticalScroll.OnBeginDrag(eventData);
        } else
        {
            base.OnBeginDrag(eventData);
        }        
    }

    public override void OnDrag(PointerEventData eventData)
    {
        if (isEnabled)
        {
            base.OnDrag(eventData);
        } else
        {
            verticalScroll.OnDrag(eventData);
        }
        
    }

    public override void OnEndDrag(PointerEventData eventData)
    {
        if (isEnabled)
        {
            base.OnEndDrag(eventData);
        } else
        {
            verticalScroll.OnEndDrag(eventData);
        }
        isEnabled = true;
    }
}
