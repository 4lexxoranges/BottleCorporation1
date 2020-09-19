using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PressedButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField]
    public Bottle bottle;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        if (!ispressed)
            return;
        bottle.Launch(ispressed);
        if (!ispressed)
            return;
        bottle.Rotation(ispressed);
        // DO SOMETHING HERE
        //Debug.Log("Pressed");

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
