using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPosOnClick : MonoBehaviour
{   
    public Camera cam;
    public GameObject despos;
    bool IsMoving = false;
    
    public GameObject menuscript; // Сюда впихивать скрипт на включение/отключение обычного gui
    void OnMouseDown()
    {  
        StopCoroutine(wtf()); // не работет 
        StartCoroutine(wtf());
    }
    
    IEnumerator wtf()
    {
        IsMoving = true;
        yield return new WaitForSecondsRealtime(1);
        if(Mathf.Ceil(cam.transform.position.x) == Mathf.Ceil(despos.transform.position.x) && Mathf.Ceil(cam.transform.position.x) == Mathf.Ceil(despos.transform.position.x)){IsMoving = false;}

    }
        

    void Update()
    {   
        if (IsMoving == true) 
        {
            cam.transform.rotation = Quaternion.RotateTowards(cam.transform.rotation,despos.transform.rotation,Time.deltaTime * 200f);
            cam.transform.position = Vector3.Lerp(cam.transform.position,despos.transform.position , Time.deltaTime * 7f);

        }
    }
}
