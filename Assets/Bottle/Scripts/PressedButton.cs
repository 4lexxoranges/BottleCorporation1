using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PressedButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public enum Movement
    {
        RotationLeft,
        RotationRight,
        Launch,
    }
    public Movement movementDirection;
    [SerializeField]
    public Bottle bottle;

    public void Update()
    {
        if (!ispressed)
            return;
        if (movementDirection == Movement.RotationLeft)
            bottle.RotationLeft();
        else if (movementDirection == Movement.RotationRight)
            bottle.RotationRight();
        else if (movementDirection == Movement.Launch)
            bottle.Launch(ispressed);
    }
    bool ispressed = false;
    public void OnPointerDown(PointerEventData eventData)
    {
        ispressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ispressed = false;
    }
}
