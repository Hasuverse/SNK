using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPosOnClick : MonoBehaviour
{   
    public GameObject despos;
    public GameObject menuscript; // Сюда впихивать скрипт на включение/отключение обычного gui
    public Camerainternal cam;


    void OnMouseDown()
    {  
        cam.MoveCam(despos);
    }
    
       

}
