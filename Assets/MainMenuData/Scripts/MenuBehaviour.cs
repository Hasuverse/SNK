using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBehaviour : MonoBehaviour
{   
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

    }

    
    void Update() {
        
    }
}
