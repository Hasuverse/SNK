using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnClick : MonoBehaviour
{   
    public UnityEvent fun;

    void OnMouseDown()
    {
        
    }

    void OnMouseOver() 
    {
           fun.Invoke();
    }

}

