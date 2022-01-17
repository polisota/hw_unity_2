using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class puzzleSlot : MonoBehaviour,IDropHandler
{
    public bool matched = false;
    public void OnDrop(PointerEventData eventData){
       if (eventData.pointerDrag != null)
       {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            
            if (eventData.pointerDrag.tag==gameObject.tag)
            {                
                matched=true;
            }else
            {
                matched=false;                
            }
       }
    }
}
