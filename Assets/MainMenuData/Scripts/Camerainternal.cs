using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Camerainternal : MonoBehaviour
{   
    public GameObject camdespos;
    public bool IsMoving = false;

    public void MoveCam(GameObject despos)
    {   
        if (IsMoving == false) // блокируем кнопки во время движения чтобы все не взъебало если их спамить
        {
            StopCoroutine (timedout());
            IsMoving = true;
            camdespos = despos; 
            StartCoroutine (timedout());
        }
    }

    void Arrival()
    {
        Debug.Log("I arrived!");
    }

    IEnumerator timedout() // ебаная камера не долетает на 0.0000000001 юнит, таймаутимся если прошло чуть меньше секунды с нажатия кнопки и мы "не долетели"
    {
        yield return new WaitForSecondsRealtime(0.6f);
        IsMoving = false;
        transform.position = camdespos.transform.position; // если каким-то образом таймаут проиcходит до того как камера долетит то тпшнуть на позицию
        Arrival();
    }

    void Update()
    {
        if (IsMoving == true) 
        {
            if(transform.rotation == camdespos.transform.rotation && transform.position == camdespos.transform.position || IsMoving == false)
            {
                IsMoving = false; 
                StopCoroutine (timedout());
                Arrival();
            }
            transform.position = Vector3.Lerp(transform.position,camdespos.transform.position , Time.deltaTime * 10f);
            transform.rotation = Quaternion.RotateTowards(transform.rotation,camdespos.transform.rotation,Time.deltaTime * 300f);

        }
    }
}
