using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class TargetDropPanel : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public static DraggableBlock d;

    void Start()
    {
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //fdgdfgdfgsdsdsdssdsdsdsd
    }

    public void OnPointerExit(PointerEventData eventData)
    {
    }

    public void OnDrop(PointerEventData eventData)
    {
        d = eventData.pointerDrag.GetComponent<DraggableBlock>();
        if (d != null)
        {
            d.parentToReturnTo = this.transform;
        }

        StartCoroutine((FindChildBlock()));
    }

    IEnumerator FindChildBlock()
    {
        yield return new WaitForSeconds(0.1f);
        Debug.Log(transform.childCount);
        if (transform.childCount > 0)
            Debug.Log(gameObject.transform.GetChild(0).gameObject.name);
    }
}
