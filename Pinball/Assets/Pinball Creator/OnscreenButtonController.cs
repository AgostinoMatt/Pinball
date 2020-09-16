using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class OnscreenButtonController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool pointerDown = false;
    public UnityEvent holdButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pointerDown)
        {
            Debug.Log("yes");
        }
    }
    public void OnPointerDown(PointerEventData eventData)
    {

        Debug.Log(this.gameObject.name + " Was Clicked.");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Reset();
    }

    public void Reset()
    {
        pointerDown = false;
    }

    public void LeftFlipper()
    {

    }

    public void Launch()
    {

    }

    public void Shake()
    {

    }
}
