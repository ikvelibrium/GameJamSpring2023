using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropHandler : MonoBehaviour, IDropHandler
{
    public int[] coctailsCount = new int[5];
    private int _coctail;

    void Start()
    {    
        _coctail = coctailsCount[Random.Range(0, coctailsCount.Length)];
        Debug.Log(_coctail);
    }

    public void OnDrop(PointerEventData eventData)
    {

        //Debug.Log("OnDrop");
        
        if (eventData.pointerDrag != null)
        { 
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            eventData.pointerDrag.GetComponent<DragnDrop>().GetID();
            if (eventData.pointerDrag.GetComponent<DragnDrop>().GetID() == _coctail)
            {
                Debug.Log("OK");
            }
            else
            {
                Debug.Log("NotOK");
            }
        }
    }


    
}
