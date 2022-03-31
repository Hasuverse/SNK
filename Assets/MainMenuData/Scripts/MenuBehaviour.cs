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

    public void ObamaCam()
    {
        Debug.Log("Obungo moment"); // Я хочу чтобы разные менюшки были с разными бг и камера плавно каталась от одной менюшки к другой. Попозже попробую все это запилить.
    }
}
