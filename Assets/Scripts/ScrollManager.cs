using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ScrollManager : MonoBehaviour
{
    
    public void OnDownEvent()
    {
        /*Debug.Log("DOWN");

        Vector2 vect = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log("mouse pos x: "+vect.x+"    y: "+vect.y);
        RaycastHit2D hit = Physics2D.Raycast(vect, Vector2.zero, Mathf.Infinity);
        Debug.Log("hit.collider!=null:" + (hit.collider!= null));
        ScrollRect scroll;
        if (hit && hit.collider)
        {
            scroll = hit.collider.GetComponent<ScrollRect>();
            //scroll.OnBeginDrag.IsInvoking;
            if (scroll != null)
            {
                //scroll.enabled = false;
            }
        }*/
    }

    private void CheckDirection(PointerEventData peData)
    {

    }

    public void OnDragEvent()
    {
        Debug.Log("DRAG");
        /*Vector2 vect = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(vect, Vector2.zero, Mathf.Infinity);
        if (hit && hit.collider)
        {
            Debug.Log("hit.collider is image"+(hit.collider.GetComponent<Image>()!=null));
        }*/
        
    }
}
