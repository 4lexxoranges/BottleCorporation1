using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Experimental.UIElements;

public class ButtonClickHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    
    public bool dragOnSurfaces = true;

    private GameObject m_DraggingIcon;
    private RectTransform m_DraggingPlane;

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
    }

    public void OnDrag(PointerEventData data)
    {
        Debug.Log("OnDrag");

    }

    private void SetDraggedPosition(PointerEventData data)
    {
        Debug.Log("SetDraggedPosition");

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");

    }
    

}
