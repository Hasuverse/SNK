using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBehaviour : MonoBehaviour
{   
    bool ismoving = false;
    public Camera cam1;
    public Camera cam2;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1); // Загружает сцену с индексом этой +1. Индексы в buildsettings 
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
    }
    public void ObamaCam()
    {
        cam1.enabled = !cam1.enabled;
        cam2.enabled = !cam2.enabled;
    }
    
        
    public void SmoothObama()
    {   

        //var campos = cam2.transform.position;
        
        // Vector3 newpos = new Vector3 (campos.x,campos.y,campos.z);
        ismoving =true;
       
    }
    
    
    void Update() {
        if (ismoving == true)
        {   
            Debug.Log("I farted");
            //cam1.transform.position = Vector3.Lerp(transform.position, , Time.deltaTime * 0.001f) ;
        }
        
    }
}
