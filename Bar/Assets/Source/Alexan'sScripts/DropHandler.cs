using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropHandler : MonoBehaviour, IDropHandler
{
    public int[] coctailsCount = new int[5];
    [SerializeField] private List<Sprite> _cocteilsSprites = new List<Sprite>();
    [SerializeField] private Image _clientsOrder;
    CutomerSpawner cutomerSpawner;
    private int _coctail;

    void Start()
    {
        int picker = Random.Range(0, coctailsCount.Length);
        _coctail = coctailsCount[picker];
        
        _clientsOrder = GameObject.FindGameObjectWithTag("ClientsOrder").GetComponent<Image>();
        cutomerSpawner = GameObject.FindGameObjectWithTag("Reaspawn").GetComponent<CutomerSpawner>();
        Debug.Log(picker);
        Debug.Log(_cocteilsSprites.Count);
        _clientsOrder.sprite = _cocteilsSprites[picker];
        
        //Debug.Log(_coctail);

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
                cutomerSpawner.Spawn();
                eventData.pointerDrag.GetComponent<DragnDrop>().Die();
                Destroy(gameObject);
            }
            else
            {
                Debug.Log("NotOK");
            }
        }
    }


    
}
